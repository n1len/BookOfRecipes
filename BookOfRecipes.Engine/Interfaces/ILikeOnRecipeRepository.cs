using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface ILikeOnRecipeRepository
    {
        void Create(LikeOnRecipeDto likeOnRecipeDto);
        void Update(LikeOnRecipeDto likeOnRecipeDto);
        void Delete(LikeOnRecipeDto likeOnRecipeDto);
        LikeOnRecipeDto GetById(Guid id);
    }
}
