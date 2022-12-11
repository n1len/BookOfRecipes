using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class LikeOnRecipeDtoExtension
    {
        public static void Create(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            LikeOnRecipePersistency.Instance.Create(context, LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Update(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            LikeOnRecipePersistency.Instance.Update(context, LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Delete(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            LikeOnRecipePersistency.Instance.Delete(context, LikeOnRecipeDtoMapper.Mapper.MapToRecord(likeOnRecipeDto));
        }

        public static LikeOnRecipeDto GetById(Guid id, DatabaseContext context)
        {
            return LikeOnRecipeDtoMapper.Mapper.MapToDto(LikeOnRecipePersistency.Instance.GetById(context, id));
        }
    }
}
