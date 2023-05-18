using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class LikeOnRecipeDtoExtension
    {
        public static void Create(this LikeOnRecipeDto likeOnRecipeDto, string connectionString)
        {
            LikeOnRecipePersistency.ConnectionString = connectionString;
            LikeOnRecipePersistency.Instance.Create(LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Update(this LikeOnRecipeDto likeOnRecipeDto, string connectionString)
        {
            LikeOnRecipePersistency.ConnectionString = connectionString;
            LikeOnRecipePersistency.Instance.Update(LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Delete(this LikeOnRecipeDto likeOnRecipeDto, string connectionString)
        {
            LikeOnRecipePersistency.ConnectionString = connectionString;
            LikeOnRecipePersistency.Instance.Delete(LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static LikeOnRecipeDto GetById(Guid id, string connectionString)
        {
            LikeOnRecipePersistency.ConnectionString = connectionString;
            return LikeOnRecipeDtoMapper.Mapper.MapToDto(LikeOnRecipePersistency.Instance.GetById(id));
        }
    }
}
