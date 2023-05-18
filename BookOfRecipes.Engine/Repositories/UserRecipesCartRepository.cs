using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRecipesCartRepository : IUserRecipesCartRepository
    {
        private readonly string _connectionString;

        public UserRecipesCartRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Create(_connectionString);
        }

        public void Update(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Update(_connectionString);
        }

        public void Delete(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Delete(_connectionString);
        }

        public UserRecipesCartDto GetById(Guid id)
        {
            return UserRecipesCartDtoExtension.GetById(id, _connectionString);
        }
    }
}
