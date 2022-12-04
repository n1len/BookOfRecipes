using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        public void Create(UserOrderDto userOrderDto)
        {
            userOrderDto.Create();
        }

        public void Update(UserOrderDto userOrderDto)
        {
            userOrderDto.Update();
        }

        public void Delete(UserOrderDto userOrderDto)
        {
            userOrderDto.Delete();
        }

        public UserOrderDto GetById(Guid id)
        {
            return UserOrderDtoExtension.GetById(id);
        }
    }
}
