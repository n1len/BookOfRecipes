using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class BookOfRecipeDtoExtension
    {
        public static void Create(this BookOfRecipeDto bookOfRecipeDto, string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            BookOfRecipePersistency.Instance.Create(BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Update(this BookOfRecipeDto bookOfRecipeDto, string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            BookOfRecipePersistency.Instance.Update(BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static void Delete(this BookOfRecipeDto bookOfRecipeDto, string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            BookOfRecipePersistency.Instance.Delete(BookOfRecipeDtoMapper.Mapper.MapToRecord(bookOfRecipeDto));
        }

        public static BookOfRecipeDto GetById(Guid id, string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            return BookOfRecipeDtoMapper.Mapper.MapToDto(BookOfRecipePersistency.Instance.GetById(id));
        }

        public static IEnumerable<BookOfRecipeDto> GetBookOfRecipeDtosByUserId(Guid userId, string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            return BookOfRecipeDtoMapper.Mapper.MapToDtos(BookOfRecipePersistency.Instance.GetBookOfRecipesByUserId(userId));
        }

        public static IEnumerable<BookOfRecipeDto> GetAllBooks(string connectionString)
        {
            BookOfRecipePersistency.ConnectionString = connectionString;
            return BookOfRecipeDtoMapper.Mapper.MapToDtos(BookOfRecipePersistency.Instance.GetAllBooks());
        }
    }
}
