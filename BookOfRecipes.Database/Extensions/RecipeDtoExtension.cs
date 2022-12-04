using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class RecipeDtoExtension
    {
        private static readonly RecipeDtoMapper _mapper = new RecipeDtoMapper();
        private static readonly PersistencyObject<Recipe> _persistencyObject = new RecipePersistency();

        public static void Create(this RecipeDto recipeDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(recipeDto));
        }

        public static void Update(this RecipeDto recipeDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(recipeDto));
        }

        public static void Delete(this RecipeDto recipeDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(recipeDto));
        }

        public static RecipeDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
