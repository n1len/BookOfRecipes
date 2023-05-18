using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserPersistency : PersistencyObject<User>
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public static UserPersistency Instance => new UserPersistency();

        public UserPersistency()
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(ConnectionString);
        }

        public override void Create(User entity)
        {
            _context.Users.Add(entity);
            base.SaveChanges(_context);
        }

        public override void Delete(User entity)
        {
            _context.Users.Remove(entity);
            base.SaveChanges(_context);
        }

        public override void Update(User entity)
        {
            _context.Users.Update(entity);
            base.SaveChanges(_context);
        }

        public override User GetById(Guid id) => _context.Users.FirstOrDefault(x => x.Id == id);

        public User GetByToken(string token) => _context.Users.FirstOrDefault(x => x.Token == token);

        public User GetByLogin(string login) => _context.Users.FirstOrDefault(x => x.Login == login);

        public IEnumerable<User> GetAllUsers() => _context.Users;
    }
}
