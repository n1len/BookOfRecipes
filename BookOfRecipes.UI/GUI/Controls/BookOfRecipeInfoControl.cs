using BookOfRecipes.Database.Dtos;
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
    public partial class BookOfRecipeInfoControl : UserControl
    {
        private readonly BookOfRecipeDto _bookOfRecipeDto;

        private RecipesInBookProcess recipesInBookProcess;

        public BookOfRecipeInfoControl(BookOfRecipeDto bookOfRecipeDto)
        {
            _bookOfRecipeDto = bookOfRecipeDto;

            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            recipesInBookProcess = new RecipesInBookProcess(_bookOfRecipeDto);
            recipesInBookProcess.Start();
        }
    }
}
