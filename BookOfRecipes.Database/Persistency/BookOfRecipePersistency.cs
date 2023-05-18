using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class BookOfRecipePersistency : PersistencyObject<BookOfRecipe>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static BookOfRecipePersistency Instance => new BookOfRecipePersistency();

        public BookOfRecipePersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(BookOfRecipe entity)
        {
            _context.BookOfRecipes.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(BookOfRecipe entity)
        {
            _context.BookOfRecipes.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(BookOfRecipe entity)
        {
            _context.BookOfRecipes.Update(entity);
            base.SaveChanges(_context);
        }

        public override BookOfRecipe GetById(Guid id) => _context.BookOfRecipes.FirstOrDefault(x => x.Id == id);

        public IEnumerable<BookOfRecipe> GetBookOfRecipesByUserId(Guid userId) => _context.BookOfRecipes.Where(x => x.UserId == userId);

        public IEnumerable<BookOfRecipe> GetAllBooks() => _context.BookOfRecipes;
    }
}
