using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;
using System.IO.IsolatedStorage;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;
        private readonly IsolatedStorageFile _isoStore;

        public UserRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
            _isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        }

        public void Create(UserDto userDto)
        {
            userDto.Create(_context);
            CreateIsolatedStorageWithToken(userDto.Token);
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

        public UserDto GetByToken()
        {
            return UserDtoExtension.GetByToken(GetTokenFromIsolatedStorage(), _context);
        }

        public UserDto GetByLogin(string login)
        {
            return UserDtoExtension.GetByLogin(login, _context);
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
