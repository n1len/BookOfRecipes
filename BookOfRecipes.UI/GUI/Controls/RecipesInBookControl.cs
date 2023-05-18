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

namespace BookOfRecipes.UI.GUI.Controls
{
    public partial class RecipeInBookControl : UserControl
    {
        private const int DefaultTextBoxTitleHeight = 57;
        private const int ActionFromUserAccountTextBoxTitleHeight = 115;

        private readonly IRecipeRepository _recipeRepository;

        private readonly UserDto _userDto;
        private readonly RecipeDto _recipeDto;

        private RecipeProcess recipeProcess;

        public RecipeInBookControl(RecipeDto recipeDto, UserDto userDto, string connectionString)
        {
            _recipeDto = recipeDto;
            _userDto = userDto;
            if (_userDto is not null)
            {
                _recipeRepository = new RecipeRepository(connectionString);
            }

            InitializeComponent();

            bool visible = _userDto is not null;
            UpdateControlComponentsDueToActionOnForm(visible);
            tbTitle.Text = _recipeDto.Title;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            recipeProcess = new RecipeProcess(_recipeDto, null, OperationType.Update);
            recipeProcess.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            recipeProcess = new RecipeProcess(_recipeDto, null, OperationType.Delete);
            recipeProcess.Start();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            recipeProcess = new RecipeProcess(_recipeDto, null, OperationType.Details);
            recipeProcess.Start();
        }

        private void UpdateControlComponentsDueToActionOnForm(bool visible)
        {
            UpdateTextBoxTitleSize(visible ? DefaultTextBoxTitleHeight : ActionFromUserAccountTextBoxTitleHeight);

            btnDelete.Visible = visible;
            btnEdit.Visible = visible;
        }

        private void UpdateTextBoxTitleSize(int height, int width = 118)
        {
            tbTitle.Size = new Size(width, height);
        }
    }
}
