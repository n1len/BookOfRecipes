using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class LikeOnRecipeRepository : ILikeOnRecipeRepository
    {
        private readonly string _connectionString;

        public LikeOnRecipeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Create(_connectionString);
        }

        public void Update(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Update(_connectionString);
        }

        public void Delete(LikeOnRecipeDto likeOnRecipeDto)
        {
            likeOnRecipeDto.Delete(_connectionString);
        }

        public LikeOnRecipeDto GetById(Guid id)
        {
            return LikeOnRecipeDtoExtension.GetById(id, _connectionString);
        }
    }
}
