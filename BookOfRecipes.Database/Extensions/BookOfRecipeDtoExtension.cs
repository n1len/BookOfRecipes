using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class BookOfRecipeDtoExtension
    {
        private static readonly BookOfRecipeDtoMapper _mapper = new BookOfRecipeDtoMapper();
        private static readonly PersistencyObject<BookOfRecipe> _persistencyObject = new BookOfRecipePersistency();

        public static void Create(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Update(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Delete(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(bookOfRecipeDto));
        }

        public static BookOfRecipeDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
