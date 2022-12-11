using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class BookOfRecipeDtoExtension
    {
        public static void Create(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            BookOfRecipePersistency.Instance.Create(context, BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Update(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            BookOfRecipePersistency.Instance.Update(context, BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Delete(this BookOfRecipeDto bookOfRecipeDto, DatabaseContext context)
        {
            BookOfRecipePersistency.Instance.Delete(context, BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static BookOfRecipeDto GetById(Guid id, DatabaseContext context)
        {
            return BookOfRecipeDtoMapper.Mapper.MapToDto(BookOfRecipePersistency.Instance.GetById(context, id));
        }

        public static IEnumerable<BookOfRecipeDto> GetBookOfRecipeDtosByUserId(Guid userId, DatabaseContext context)
        {
            return BookOfRecipeDtoMapper.Mapper.MapToDtos(BookOfRecipePersistency.Instance.GetBookOfRecipesByUserId(context, userId));
        }

        public static IEnumerable<BookOfRecipeDto> GetAllBooks(DatabaseContext context)
        {
            return BookOfRecipeDtoMapper.Mapper.MapToDtos(BookOfRecipePersistency.Instance.GetAllBooks(context));
        }
    }
}
