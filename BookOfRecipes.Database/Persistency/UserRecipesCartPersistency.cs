using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserRecipesCartPersistency : PersistencyObject<UserRecipesCart>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static UserRecipesCartPersistency Instance => new UserRecipesCartPersistency();

        public UserRecipesCartPersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }

        public override UserRecipesCart GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Update(UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }
    }
}
