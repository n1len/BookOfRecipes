using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class RecipeDtoExtension
    {
        public static void Create(this RecipeDto recipeDto, string connectionString)
        {
            RecipePersistency.ConnectionString = connectionString;
            RecipePersistency.Instance.Create(RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static void Update(this RecipeDto recipeDto, string connectionString)
        {
            RecipePersistency.ConnectionString = connectionString;
            RecipePersistency.Instance.Update(RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static void Delete(this RecipeDto recipeDto, string connectionString)
        {
            RecipePersistency.ConnectionString = connectionString;
            RecipePersistency.Instance.Delete(RecipeDtoMapper.Mapper.MapToRecord(recipeDto));
        }

        public static RecipeDto GetById(Guid id, string connectionString)
        {
            RecipePersistency.ConnectionString = connectionString;
            return RecipeDtoMapper.Mapper.MapToDto(RecipePersistency.Instance.GetById(id));
        }

        public static IEnumerable<RecipeDto> GetRecipeDtosByBookId(Guid bookId, string connectionString)
        {
            RecipePersistency.ConnectionString = connectionString;
            return RecipeDtoMapper.Mapper.MapToDtos(RecipePersistency.Instance.GetRecipeDtosByBookId(bookId));
        }
    }
}
