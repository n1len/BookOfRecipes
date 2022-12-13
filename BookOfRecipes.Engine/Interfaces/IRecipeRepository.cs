using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IRecipeRepository
    {
        void Create(RecipeDto recipeDto);
        void Update(RecipeDto recipeDto);
        void Delete(RecipeDto recipeDto);
        RecipeDto GetById(Guid id);
        IEnumerable<RecipeDto> GetRecipeDtosByBookId(Guid bookId);
    }
}
