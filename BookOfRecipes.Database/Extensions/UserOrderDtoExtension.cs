using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserOrderDtoExtension
    {
        private static readonly UserOrderDtoMapper _mapper = new UserOrderDtoMapper();
        private static readonly PersistencyObject<UserOrder> _persistencyObject = new UserOrderPersistency();

        public static void Create(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(userOrderDto));
        }

        public static void Update(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(userOrderDto));
        }

        public static void Delete(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(userOrderDto));
        }

        public static UserOrderDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
