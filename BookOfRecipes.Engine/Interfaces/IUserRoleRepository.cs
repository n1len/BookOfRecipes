using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IUserRoleRepository
    {
        void Create(UserRoleDto userRoleDto);
        void Update(UserRoleDto userRoleDto);
        void Delete(UserRoleDto userRoleDto);
        UserRoleDto GetById(Guid id);
    }
}
