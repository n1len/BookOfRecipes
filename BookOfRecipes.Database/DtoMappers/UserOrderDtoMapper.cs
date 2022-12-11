using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class UserOrderDtoMapper : BaseDtoMapper<UserOrderDto, UserOrder>
    {
        public static UserOrderDtoMapper Mapper => new UserOrderDtoMapper();
        public override UserOrderDto MapToDto(UserOrder record)
        {
            if (record == null)
            {
                return null;
            }

            return new UserOrderDto()
            {
                Id = record.Id,
                UserRecipesCartDtoId = record.UserRecipesCartId,
                UserDtoId = record.UserId
            };
        }

        public override UserOrder MapToRecord(UserOrderDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new UserOrder()
            {
                Id = dto.Id,
                UserRecipesCartId = dto.UserRecipesCartDtoId,
                UserId = dto.UserDtoId
            };
        }
    }
}
