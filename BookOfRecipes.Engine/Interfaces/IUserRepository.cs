using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IUserRepository
    {
        void Create(UserDto userDto);
        void Update(UserDto userDto);
        void Delete(UserDto userDto);
        UserDto GetById(Guid id);
        UserDto GetByToken();
        UserDto GetByLogin(string login);
        void CreateIsolatedStorageWithToken(string token);
        void DeleteIsolatedStorage(string fileName = "Token.txt");
    }
}
