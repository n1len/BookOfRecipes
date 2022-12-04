using BookOfRecipes.Database.Dtos;

namespace BookOfRecipes.Engine.Interfaces
{
    public interface IUserOrderRepository
    {
        void Create(UserOrderDto userOrderDto);
        void Update(UserOrderDto userOrderDto);
        void Delete(UserOrderDto userOrderDto);
        UserOrderDto GetById(Guid id);
    }
}
