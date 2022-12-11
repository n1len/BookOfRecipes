using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IBookOfRecipeRepository
    {
        void Create(BookOfRecipeDto bookOfRecipeDto);
        void Update(BookOfRecipeDto bookOfRecipeDto);
        void Delete(BookOfRecipeDto bookOfRecipeDto);
        BookOfRecipeDto GetById(Guid id);
        IEnumerable<BookOfRecipeDto> GetBookOfRecipeDtosByUserId(Guid userId);
        IEnumerable<BookOfRecipeDto> GetAllBooks();
    }
}
