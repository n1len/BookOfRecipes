using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly string _connectionString;

        public RecipeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(RecipeDto recipeDto)
        {
            recipeDto.Create(_connectionString);
        }

        public void Update(RecipeDto recipeDto)
        {
            recipeDto.Update(_connectionString);
        }

        public void Delete(RecipeDto recipeDto)
        {
            recipeDto.Delete(_connectionString);
        }

        public RecipeDto GetById(Guid id)
        {
            return RecipeDtoExtension.GetById(id, _connectionString);
        }

        public IEnumerable<RecipeDto> GetRecipeDtosByBookId(Guid bookId)
        {
            return RecipeDtoExtension.GetRecipeDtosByBookId(bookId, _connectionString);
        }
    }
}
