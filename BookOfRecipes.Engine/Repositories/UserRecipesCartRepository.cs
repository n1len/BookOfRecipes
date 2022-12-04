using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserRecipesCartRepository : IUserRecipesCartRepository
    {
        public void Create(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Create();
        }

        public void Update(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Update();
        }

        public void Delete(UserRecipesCartDto userRecipesCartDto)
        {
            userRecipesCartDto.Delete();
        }

        public UserRecipesCartDto GetById(Guid id)
        {
            return UserRecipesCartDtoExtension.GetById(id);
        }
    }
}
