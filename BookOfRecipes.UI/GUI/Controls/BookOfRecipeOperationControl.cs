using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookOfRecipes.UI.GUI.Controls
{
    public partial class BookOfRecipeOperationControl : UserControl
    {
        private readonly IBookOfRecipeRepository _bookOfRecipeRepository;

        private readonly UserDto _user;
        private readonly BookOfRecipeDto _bookOfRecipe;

        private readonly OperationType _operationType;

        public BookOfRecipeOperationControl(string connectionString, UserDto userDto, OperationType operationType, BookOfRecipeDto bookOfRecipe)
        {
            _bookOfRecipeRepository = new BookOfRecipeRepository(connectionString);
            _user = userDto;
            _bookOfRecipe = bookOfRecipe;
            _operationType = operationType;

            InitializeComponent();

            UpdateUI();
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
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            switch (_operationType)
            {
                case OperationType.Create:
                    _bookOfRecipeRepository.Create(new BookOfRecipeDto()
                    {
                        Title = tbTitle.Text,
                        Description = tbDescription.Text,
                        Img = tbImage.Text,
                        UserDtoId = _user.Id,
                    });
                    break;
                case OperationType.Update:
                    _bookOfRecipe.Title = tbTitle.Text;
                    _bookOfRecipe.Description = tbDescription.Text;
                    _bookOfRecipe.Img = tbImage.Text;

                    _bookOfRecipeRepository.Update(_bookOfRecipe);
                    break;
                case OperationType.Delete:
                    _bookOfRecipeRepository.Delete(_bookOfRecipe);
                    break;
            }

            DialogResult result = MessageBox.Show("Operation done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void UpdateText(string text)
        {
            const string constText = " book of recipe";
            lbControlName.Text = text + constText;
            btnOperation.Text = text;
        }

        private void FillTextBoxes()
        {
            tbTitle.Text = _bookOfRecipe.Title;
            tbDescription.Text = _bookOfRecipe.Description;
            tbImage.Text = _bookOfRecipe.Img;
        }
    }
}
