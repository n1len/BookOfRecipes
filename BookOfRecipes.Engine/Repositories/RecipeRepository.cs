using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        public void Create(RecipeDto recipeDto)
        {
            recipeDto.Create();
        }

        public void Update(RecipeDto recipeDto)
        {
            recipeDto.Update();
        }

        public void Delete(RecipeDto recipeDto)
        {
            recipeDto.Delete();
        }

        public RecipeDto GetById(Guid id)
        {
            return RecipeDtoExtension.GetById(id);
        }
    }
}
