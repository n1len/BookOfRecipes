using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserOrderDtoExtension
    {
        public static void Create(this UserOrderDto userOrderDto, string connectionString)
        {
            UserOrderPersistency.ConnectionString = connectionString;
            UserOrderPersistency.Instance.Create(UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static void Update(this UserOrderDto userOrderDto, string connectionString)
        {
            UserOrderPersistency.ConnectionString = connectionString;
            UserOrderPersistency.Instance.Update(UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static void Delete(this UserOrderDto userOrderDto, string connectionString)
        {
            UserOrderPersistency.ConnectionString = connectionString;
            UserOrderPersistency.Instance.Delete(UserOrderDtoMapper.Mapper.MapToRecord(userOrderDto));
        }

        public static UserOrderDto GetById(Guid id, string connectionString)
        {
            UserOrderPersistency.ConnectionString = connectionString;
            return UserOrderDtoMapper.Mapper.MapToDto(UserOrderPersistency.Instance.GetById(id));
        }
    }
}
