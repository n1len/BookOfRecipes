using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly string _connectionString;

        public UserRoleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(UserRoleDto userRoleDto)
        {
            userRoleDto.Create(_connectionString);
        }

        public void Update(UserRoleDto userRoleDto)
        {
            userRoleDto.Update(_connectionString);
        }

        public void Delete(UserRoleDto userRoleDto)
        {
            userRoleDto.Delete(_connectionString);
        }

        public UserRoleDto GetById(Guid id)
        {
            return UserRoleDtoExtension.GetById(id, _connectionString);
        }

        public UserRoleDto GetByName(string name)
        {
            return UserRoleDtoExtension.GetByName(name, _connectionString);
        }

        public IEnumerable<UserRoleDto> GetAllRoles() 
        {
            return UserRoleDtoExtension.GetAllRoles(_connectionString);
        }
    }
}
