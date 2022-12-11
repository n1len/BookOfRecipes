using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class RecipeProcess : BaseProcess
    {
        private readonly RecipeForm Form;

        private readonly RecipeDto _recipeDto;
        private readonly BookOfRecipeDto _bookOfRecipeDto;
        private readonly OperationType _operationType;

        public RecipeProcess(BookOfRecipeDto bookOfRecipeDto, OperationType operationType) 
        {
            Form = new RecipeForm();

            _bookOfRecipeDto = bookOfRecipeDto;
            _operationType = operationType;

            InitializeHandle();
        }

        public RecipeProcess(RecipeDto recipeDto, BookOfRecipeDto bookOfRecipeDto, OperationType operationType) : this(bookOfRecipeDto, operationType)
        {
            _recipeDto = recipeDto;
        }

        public void Start()
        {
            Form.RecipeOperationPanel.Controls.Add(new RecipeOperationControl(ConnectionString, _bookOfRecipeDto, _operationType, _recipeDto));
            Form.Show();
        }

        private void InitializeHandle()
        {
            Form.RecipeOperationPanel.ControlRemoved += CloseForm;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
