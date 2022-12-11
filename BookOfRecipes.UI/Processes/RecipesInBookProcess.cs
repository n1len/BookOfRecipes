using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class RecipesInBookProcess : BaseProcess
    {
        private readonly IRecipeRepository _recipeRepository;

        private readonly BookOfRecipeDto _bookOfRecipeDto;
        private readonly UserDto _userDto;

        private readonly RecipesInBookForm Form;

        private RecipeProcess recipeProcess;

        public RecipesInBookProcess(BookOfRecipeDto bookOfRecipeDto)
        {
            Form = new RecipesInBookForm();
            _bookOfRecipeDto = bookOfRecipeDto;

            InitializeHandle();
            FillTextBoxes();
            UpdateVisibleButtons(false);
        }

        public RecipesInBookProcess(BookOfRecipeDto bookOfRecipeDto, UserDto userDto) : this(bookOfRecipeDto)
        {
            _recipeRepository = new RecipeRepository(ConnectionString);
            _userDto = userDto;
            UpdateVisibleButtons(true);
        }

        public void Start()
        {
            Form.Show();
        }

        private void UpdateVisibleButtons(bool visible)
        {
            Form.BtnCreateRecipe.Visible = visible;
        }

        private void FillTextBoxes()
        {
            Form.TbTitle.Text = _bookOfRecipeDto.Title;
            Form.TbDescription.Text = _bookOfRecipeDto.Description;
        }

        private void InitializeHandle()
        {
            Form.BtnCreateRecipe.Click += CreateRecipe;
            Form.BtnNextPage.Click += MoveToNextPage;
            Form.BtnPreviousPage.Click += MoveToPreviousPage;
            Form.BtnRefreshPage.Click += RefreshForm;
        }

        private void CreateRecipe(object sender, EventArgs e)
        {
            recipeProcess = new RecipeProcess(_bookOfRecipeDto, OperationType.Create);
            recipeProcess.Start();
        }

        private void MoveToNextPage(object sender, EventArgs e)
        {

        }

        private void MoveToPreviousPage(object sender, EventArgs e)
        {

        }

        private void RefreshForm(object sender, EventArgs e)
        {

        }
    }
}
