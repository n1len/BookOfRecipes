using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class BookOfRecipeProcess : BaseProcess
    {
        private readonly BookOfRecipeForm Form;

        private readonly UserDto _user;
        private readonly BookOfRecipeDto _bookOfRecipe;
        private readonly OperationType _operationType;

        public BookOfRecipeProcess(UserDto userDto, OperationType operationType)
        {
            Form = new BookOfRecipeForm();
            _user = userDto;
            _operationType = operationType;

            InitializeHandle();
        }

        public BookOfRecipeProcess(UserDto userDto, BookOfRecipeDto bookOfRecipeDto, OperationType operationType) : this(userDto, operationType)
        {
            _bookOfRecipe = bookOfRecipeDto;
        }

        public void Start()
        {
            Form.OperationPanel.Controls.Add(new BookOfRecipeOperationControl(ConnectionString, _user, _operationType, _bookOfRecipe));
            Form.Show();
        }

        private void InitializeHandle()
        {
            Form.OperationPanel.ControlRemoved += CloseForm;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
