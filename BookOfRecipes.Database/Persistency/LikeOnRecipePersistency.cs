using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class LikeOnRecipePersistency : PersistencyObject<LikeOnRecipe>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static LikeOnRecipePersistency Instance => new LikeOnRecipePersistency();

        public LikeOnRecipePersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(LikeOnRecipe entity)
        {
            _context.LikeOnRecipes.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(LikeOnRecipe entity)
        {
            _context.LikeOnRecipes.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(LikeOnRecipe entity)
        {
            _context.LikeOnRecipes.Update(entity);
            base.SaveChanges(_context);
        }

        public override LikeOnRecipe GetById(Guid id) => _context.LikeOnRecipes.FirstOrDefault(x => x.Id == id);
    }
}
