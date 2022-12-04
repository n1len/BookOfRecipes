using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public RecipeRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(RecipeDto recipeDto)
        {
            recipeDto.Create(_context);
        }

        public void Update(RecipeDto recipeDto)
        {
            recipeDto.Update(_context);
        }

        public void Delete(RecipeDto recipeDto)
        {
            recipeDto.Delete(_context);
        }

        public RecipeDto GetById(Guid id)
        {
            return RecipeDtoExtension.GetById(id, _context);
        }
    }
}
