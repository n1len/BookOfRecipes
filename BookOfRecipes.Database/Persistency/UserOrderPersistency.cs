using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserOrderPersistency : PersistencyObject<UserOrder>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static UserOrderPersistency Instance => new UserOrderPersistency();

        public UserOrderPersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(UserOrder entity)
        {
            _context.UserOrders.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(UserOrder entity)
        {
            _context.UserOrders.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(UserOrder entity)
        {
            _context.UserOrders.Update(entity);
            base.SaveChanges(_context);
        }

        public override UserOrder GetById(Guid id) => _context.UserOrders.FirstOrDefault(x => x.Id == id);
    }
}
