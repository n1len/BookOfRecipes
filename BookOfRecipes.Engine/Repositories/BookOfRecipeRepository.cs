using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class BookOfRecipeRepository : IBookOfRecipeRepository
    {
        private readonly string _connectionString;

        public BookOfRecipeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Create(_connectionString);
        }

        public void Update(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Update(_connectionString);
        }

        public void Delete(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Delete(_connectionString);
        }

        public BookOfRecipeDto GetById(Guid id)
        {
            return BookOfRecipeDtoExtension.GetById(id, _connectionString);
        }

        public IEnumerable<BookOfRecipeDto> GetBookOfRecipeDtosByUserId(Guid userId) 
        {
            return BookOfRecipeDtoExtension.GetBookOfRecipeDtosByUserId(userId, _connectionString);
        }

        public IEnumerable<BookOfRecipeDto> GetAllBooks()
        {
            return BookOfRecipeDtoExtension.GetAllBooks(_connectionString);
        }
    }
}
