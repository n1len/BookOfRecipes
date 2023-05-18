using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;
using System.IO.IsolatedStorage;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        private readonly IsolatedStorageFile _isoStore;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
            _isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        }

        public void Create(UserDto userDto)
        {
            userDto.Create(_connectionString);
            CreateIsolatedStorageWithToken(userDto.Token);
        }

        public void Update(UserDto userDto)
        {
            userDto.Update(_connectionString);
        }

        public void Delete(UserDto userDto)
        {
            userDto.Delete(_connectionString);
        }

        public UserDto GetById(Guid id)
        {
            return UserDtoExtension.GetById(id, _connectionString);
        }

        public UserDto GetByToken()
        {
            return UserDtoExtension.GetByToken(GetTokenFromIsolatedStorage(), _connectionString);
        }

        public UserDto GetByLogin(string login)
        {
            return UserDtoExtension.GetByLogin(login, _connectionString);
        }

        public IEnumerable<UserDto> GetAllUsers() 
        {
            return UserDtoExtension.GetAllUsers(_connectionString);
        }

        public void CreateIsolatedStorageWithToken(string token)
        {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("Token.txt", FileMode.Create, _isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.WriteLine(token);
                }
            }
        }

        public void DeleteIsolatedStorage(string fileName = "Token.txt")
        {
            if (_isoStore.FileExists(fileName))
            {
                _isoStore.DeleteFile(fileName);
            }
        }

        private string GetTokenFromIsolatedStorage(string fileName = "Token.txt")
        {
            if (_isoStore.FileExists(fileName))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(fileName, FileMode.Open, _isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        return reader.ReadLine();
                    }
                }
            }

            return string.Empty;
        }
    }
}
