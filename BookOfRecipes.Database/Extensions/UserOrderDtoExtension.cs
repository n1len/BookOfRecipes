using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserOrderDtoExtension
    {
        public static void Create(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            UserOrderPersistency.Instance.Create(context, UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static void Update(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            UserOrderPersistency.Instance.Update(context, UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static void Delete(this UserOrderDto userOrderDto, DatabaseContext context)
        {
            UserOrderPersistency.Instance.Delete(context, UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static UserOrderDto GetById(Guid id, DatabaseContext context)
        {
            return UserOrderDtoMapper.Mapper.MapToDto(UserOrderPersistency.Instance.GetById(context, id));
        }
    }
}
