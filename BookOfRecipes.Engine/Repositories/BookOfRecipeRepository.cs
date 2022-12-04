using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class BookOfRecipeRepository : IBookOfRecipeRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public BookOfRecipeRepository(string connectionString)
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Create(_context);
        }

        public void Update(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Update(_context);
        }

        public void Delete(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Delete(_context);
        }

        public BookOfRecipeDto GetById(Guid id)
        {
            return BookOfRecipeDtoExtension.GetById(id, _context);
        }
    }
}
