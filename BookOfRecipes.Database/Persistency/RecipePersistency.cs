using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class RecipePersistency : PersistencyObject<Recipe>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static RecipePersistency Instance => new RecipePersistency();

        public RecipePersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(Recipe entity)
        {
            _context.Recipes.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(Recipe entity)
        {
            _context.Recipes.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(Recipe entity)
        {
            _context.Recipes.Update(entity);
            base.SaveChanges(_context);
        }

        public override Recipe GetById(Guid id) => _context.Recipes.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Recipe> GetRecipeDtosByBookId(Guid bookId) => _context.Recipes.Where(x => x.BookOfRecipeId == bookId);
    }
}
