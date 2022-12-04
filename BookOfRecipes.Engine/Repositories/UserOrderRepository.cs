using BookOfRecipes.Database;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private readonly IDatabaseContextFactory<DatabaseContext> _databaseContextFactory;
        private readonly DatabaseContext _context;

        public UserOrderRepository(string connectionString) 
        {
            _databaseContextFactory = new DatabaseContextFactory();
            _context = _databaseContextFactory.CreateDatabaseContext(connectionString);
        }

        public void Create(UserOrderDto userOrderDto)
        {
            userOrderDto.Create(_context);
        }

        public void Update(UserOrderDto userOrderDto)
        {
            userOrderDto.Update(_context);
        }

        public void Delete(UserOrderDto userOrderDto)
        {
            userOrderDto.Delete(_context);
        }

        public UserOrderDto GetById(Guid id)
        {
            return UserOrderDtoExtension.GetById(id, _context);
        }
    }
}
