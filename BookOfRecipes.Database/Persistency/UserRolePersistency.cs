using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserRolePersistency : PersistencyObject<UserRole>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static UserRolePersistency Instance => new UserRolePersistency();

        public UserRolePersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(UserRole entity)
        {
            _context.UserRoles.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(UserRole entity)
        {
            _context.UserRoles.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(UserRole entity)
        {
            _context.UserRoles.Update(entity);
            base.SaveChanges(_context);
        }

        public override UserRole GetById(Guid id) => _context.UserRoles.FirstOrDefault(x => x.Id == id);

        public UserRole GetByName(string name) => _context.UserRoles.FirstOrDefault(x => x.RoleName == name);

        public IEnumerable<UserRole> GetAllRoles() => _context.UserRoles;
    }
}
