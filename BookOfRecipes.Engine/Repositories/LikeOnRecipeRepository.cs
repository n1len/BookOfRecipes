using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class LikeOnRecipeRepository : ILikeOnRecipeRepository
    {
        public void Create(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Create();
        }

        public void Update(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Update();
        }

        public void Delete(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Delete();
        }

        public LikeOnRecipeDto GetById(Guid id)
        {
            return LikeOnRecipeDtoExtension.GetById(id);
        }
    }
}
