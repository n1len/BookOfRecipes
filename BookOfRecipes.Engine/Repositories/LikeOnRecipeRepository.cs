using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class LikeOnRecipeRepository : ILikeOnRecipeRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public LikeOnRecipeRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Create(_context);
        }

        public void Update(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Update(_context);
        }

        public void Delete(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Delete(_context);
        }

        public LikeOnRecipeDto GetById(Guid id)
        {
            return LikeOnRecipeDtoExtension.GetById(id, _context);
        }
    }
}
