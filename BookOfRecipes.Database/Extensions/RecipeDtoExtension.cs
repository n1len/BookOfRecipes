using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class RecipeDtoExtension
    {
        public static void Create(this RecipeDto recipeDto, DatabaseContext context)
        {
            RecipePersistency.Instance.Create(context, RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static void Update(this RecipeDto recipeDto, DatabaseContext context)
        {
            RecipePersistency.Instance.Update(context, RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static void Delete(this RecipeDto recipeDto, DatabaseContext context)
        {
            RecipePersistency.Instance.Delete(context, RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static RecipeDto GetById(Guid id, DatabaseContext context)
        {
            return RecipeDtoMapper.Mapper.MapToDto(RecipePersistency.Instance.GetById(context, id));
        }

        public static IEnumerable<RecipeDto> GetRecipeDtosByBookId(Guid bookId, DatabaseContext context)
        {
            return RecipeDtoMapper.Mapper.MapToDtos(RecipePersistency.Instance.GetRecipeDtosByBookId(context, bookId));
        }
    }
}
