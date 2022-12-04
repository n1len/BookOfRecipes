using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        public void Create(UserRoleDto userRoleDto)
        {
            userRoleDto.Create();
        }

        public void Update(UserRoleDto userRoleDto)
        {
            userRoleDto.Update();
        }

        public void Delete(UserRoleDto userRoleDto)
        {
            userRoleDto.Delete();
        }

        public UserRoleDto GetById(Guid id)
        {
            return UserRoleDtoExtension.GetById(id);
        }
    }
}
