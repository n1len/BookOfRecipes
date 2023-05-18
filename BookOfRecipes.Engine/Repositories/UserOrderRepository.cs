using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Extensions;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private readonly string _connectionString;

        public UserOrderRepository(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public void Create(UserOrderDto userOrderDto)
        {
            userOrderDto.Create(_connectionString);
        }

        public void Update(UserOrderDto userOrderDto)
        {
            userOrderDto.Update(_connectionString);
        }

        public void Delete(UserOrderDto userOrderDto)
        {
            userOrderDto.Delete(_connectionString);
        }

        public UserOrderDto GetById(Guid id)
        {
            return UserOrderDtoExtension.GetById(id, _connectionString);
        }
    }
}
