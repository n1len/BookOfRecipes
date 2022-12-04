using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class LikeOnRecipeDtoExtension
    {
        private static readonly LikeOnRecipeDtoMapper _mapper = new LikeOnRecipeDtoMapper();
        private static readonly PersistencyObject<LikeOnRecipe> _persistencyObject = new LikeOnRecipePersistency();

        public static void Create(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Update(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(likeOnRecipeDto));
        }

        public static void Delete(this LikeOnRecipeDto likeOnRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(likeOnRecipeDto));
        }

        public static LikeOnRecipeDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
