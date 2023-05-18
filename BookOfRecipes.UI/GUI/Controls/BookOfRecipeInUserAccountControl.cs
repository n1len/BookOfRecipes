using BookOfRecipes.Database.Dtos;
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
    public partial class BookOfRecipeInUserAccountControl : UserControl
    {
        private readonly BookOfRecipeDto _bookOfRecipeDto;
        private readonly UserDto _userDto;

        private BookOfRecipeProcess _bookOfRecipeProcess;
        private RecipesInBookProcess _recipesInBookProcess;

        public BookOfRecipeInUserAccountControl(BookOfRecipeDto bookOfRecipeDto, UserDto userDto)
        {
            _bookOfRecipeDto = bookOfRecipeDto;
            _userDto = userDto;

            InitializeComponent();
            tbTitle.Text = _bookOfRecipeDto.Title;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _bookOfRecipeProcess = new BookOfRecipeProcess(_userDto, _bookOfRecipeDto, OperationType.Update);
            _bookOfRecipeProcess.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bookOfRecipeProcess = new BookOfRecipeProcess(_userDto, _bookOfRecipeDto, OperationType.Delete);
            _bookOfRecipeProcess.Start();
        }

        private void btnToRecipes_Click(object sender, EventArgs e)
        {
            _recipesInBookProcess = new RecipesInBookProcess(_bookOfRecipeDto, _userDto);
            _recipesInBookProcess.Start();
        }
    }
}
