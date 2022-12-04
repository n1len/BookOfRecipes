using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IUserRepository
    {
        void Create(UserDto userDto);
        void Update(UserDto userDto);
        void Delete(UserDto userDto);
        UserDto GetById(Guid id);
    }
}
