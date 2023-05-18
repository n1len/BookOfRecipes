using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.Shared.Records;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BookOfRecipes.UI.GUI.Controls
{
    public partial class RecipeOperationControl : UserControl
    {
        private readonly IRecipeRepository _recipeRepository;

        private readonly BookOfRecipeDto _bookOfRecipeDto;
        private readonly RecipeDto _recipeDto;
        private readonly OperationType _operationType;

        public RecipeOperationControl(string connectionString, BookOfRecipeDto bookOfRecipeDto, OperationType operationType, RecipeDto recipeDto)
        {
            _recipeRepository = new RecipeRepository(connectionString);
            _bookOfRecipeDto = bookOfRecipeDto;
            _recipeDto = recipeDto;
            _operationType = operationType;

            InitializeComponent();

            UpdateUI();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            switch (_operationType)
            {
                case OperationType.Create:
                    _recipeRepository.Create(new RecipeDto()
                    {
                        Title = tbTitle.Text,
                        DescriptionField = tbDescription.Text,
                        Tags = tbTags.Text,
                        BookOfRecipeDtoId = _bookOfRecipeDto.Id,
                    });
                    break;
                case OperationType.Update:
                    _recipeDto.Title = tbTitle.Text;
                    _recipeDto.DescriptionField = tbDescription.Text;
                    _recipeDto.Tags = tbTags.Text;

                    _recipeRepository.Update(_recipeDto);
                    break;
                case OperationType.Delete:
                    _recipeRepository.Delete(_recipeDto);
                    break;
            }

            DialogResult result = MessageBox.Show("Operation done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void UpdateUI()
        {
            switch (_operationType)
            {
                case OperationType.Create:
                    UpdateText("Create new");
                    break;
                case OperationType.Update:
                    UpdateText("Edit");
                    FillTextBoxes();
                    break;
                case OperationType.Delete:
                    UpdateText("Delete");
                    FillTextBoxes();
                    break;
                case OperationType.Details:
                    UpdateControlSettings(true);
                    UpdateText("Details");
                    FillTextBoxes();
                    break;
            }
        }

        private void UpdateControlSettings(bool setting)
        {
            tbDescription.ReadOnly = setting;
            tbTags.ReadOnly = setting;
            tbTitle.ReadOnly = setting;
            btnOperation.Visible = !setting;
        }

        private void UpdateText(string text)
        {
            const string constText = " recipe";
            lbOperationWithRecipe.Text = text + constText;
            btnOperation.Text = text;
        }

        private void FillTextBoxes()
        {
            tbTitle.Text = _recipeDto.Title;
            tbDescription.Text = _recipeDto.DescriptionField;
            tbTags.Text = _recipeDto.Tags;
        }
    }
}
