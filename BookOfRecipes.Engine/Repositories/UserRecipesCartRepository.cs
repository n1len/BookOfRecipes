using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRecipesCartRepository : IUserRecipesCartRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public UserRecipesCartRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Create(_context);
        }

        public void Update(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Update(_context);
        }

        public void Delete(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Delete(_context);
        }

        public UserRecipesCartDto GetById(Guid id)
        {
            return UserRecipesCartDtoExtension.GetById(id, _context);
        }
    }
}
