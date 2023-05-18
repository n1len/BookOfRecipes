using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class RecipesInBookProcess : BaseProcess
    {
        private const int ItemsPerPage = 4;

        private readonly IRecipeRepository _recipeRepository;

        private readonly BookOfRecipeDto _bookOfRecipeDto;
        private readonly UserDto _userDto;

        private readonly RecipesInBookForm Form;

        private RecipeProcess recipeProcess;

        private int page = 0;

        public RecipesInBookProcess(BookOfRecipeDto bookOfRecipeDto, UserDto userDto)
        {
            Form = new RecipesInBookForm();
            _bookOfRecipeDto = bookOfRecipeDto;
            _recipeRepository = new RecipeRepository(ConnectionString);
            _userDto = userDto;

            bool visible = _userDto is not null;

            InitializeHandle();
            FillTextBoxes();
            FillPanelWithRecipesByPage(_userDto);
            
            UpdateVisibleButtons(visible);
        }

        public void Start()
        {
            Form.ShowDialog();
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
            page++;
            MoveToPage();
        }

        private void MoveToPreviousPage(object sender, EventArgs e)
        {
            page--;
            if (page <= 0)
            {
                page = 0;
            }
            MoveToPage();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            ClearControlWithRecipes();
            FillPanelWithRecipesByPage(_userDto);
        }

        private void UpdateVisibleButtons(bool visible)
        {
            Form.BtnCreateRecipe.Visible = visible;
        }

        private void FillPanelWithRecipesByPage(UserDto userDto)
        {
            Form.Size = new Size(566, 323);
            Form.LbCollectionIsEmpty.Visible = false;
            Form.RecipesInBookPanel.Visible = true;
            var recipes = _recipeRepository.GetRecipeDtosByBookId(_bookOfRecipeDto.Id)
                .Skip(page * ItemsPerPage).Take(ItemsPerPage);

            if (recipes.Any())
            {
                foreach (var recipe in recipes)
                {
                    Form.RecipesInBookPanel.Controls.Add(new RecipeInBookControl(recipe, userDto, ConnectionString));
                }
                return;
            }

            Form.Size = new Size(566, 175);
            Form.LbCollectionIsEmpty.Location = new Point(190,112);
            Form.LbCollectionIsEmpty.Visible = true;
            Form.RecipesInBookPanel.Visible = false;
        }

        private void FillTextBoxes()
        {
            Form.TbTitle.Text = _bookOfRecipeDto.Title;
            Form.TbDescription.Text = _bookOfRecipeDto.Description;
        }

        private void MoveToPage()
        {
            Form.LbPage.Text = "Page: " + (page + 1);
            ClearControlWithRecipes();
            FillPanelWithRecipesByPage(_userDto);
        }

        private void ClearControlWithRecipes()
        {
            Form.RecipesInBookPanel.Controls.Clear();
        }
    }
}
