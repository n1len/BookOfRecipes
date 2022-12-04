using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public UserRoleRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(UserRoleDto userRoleDto)
        {
            userRoleDto.Create(_context);
        }

        public void Update(UserRoleDto userRoleDto)
        {
            userRoleDto.Update(_context);
        }

        public void Delete(UserRoleDto userRoleDto)
        {
            userRoleDto.Delete(_context);
        }

        public UserRoleDto GetById(Guid id)
        {
            return UserRoleDtoExtension.GetById(id, _context);
        }
    }
}
