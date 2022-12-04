using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public UserRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(UserDto userDto)
        {
            userDto.Create(_context);
        }

        public void Update(UserDto userDto)
        {
            userDto.Update(_context);
        }

        public void Delete(UserDto userDto)
        {
            userDto.Delete(_context);
        }

        public UserDto GetById(Guid id)
        {
            return UserDtoExtension.GetById(id, _context);
        }
    }
}
