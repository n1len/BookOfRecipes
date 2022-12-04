using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Create(UserDto userDto)
        {
            userDto.Create();
        }

        public void Update(UserDto userDto)
        {
            userDto.Update();
        }

        public void Delete(UserDto userDto)
        {
            userDto.Delete();
        }

        public UserDto GetById(Guid id)
        {
            return UserDtoExtension.GetById(id);
        }
    }
}
