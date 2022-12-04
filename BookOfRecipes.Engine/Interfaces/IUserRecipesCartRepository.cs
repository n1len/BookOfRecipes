using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IUserRecipesCartRepository
    {
        void Create(UserRecipesCartDto userRecipesCartDto);
        void Update(UserRecipesCartDto userRecipesCartDto);
        void Delete(UserRecipesCartDto userRecipesCartDto);
        UserRecipesCartDto GetById(Guid id);
    }
}
