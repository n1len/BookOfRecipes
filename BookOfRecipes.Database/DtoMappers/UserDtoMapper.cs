using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class UserDtoMapper : BaseDtoMapper<UserDto, User>
    {
        public override UserDto MapToDto(User record)
        {
            if (record == null)
            {
                return null;
            }

            return new UserDto()
            {
                Id = record.Id,
                Name = record.Name,
                Surname = record.Surname,
                Login = record.Login,
                Password = record.Password,
                IsBlocked = record.IsBlocked,
                UserRoleDtoId = record.UserRoleId,
                LikeOnRecipesDto = record.LikeOnRecipes.Cast<LikeOnRecipeDto>().ToList(),
                BookOfRecipesDto = record.BookOfRecipes.Cast<BookOfRecipeDto>().ToList()
            };
        }

        public override User MapToRecord(UserDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new User()
            {
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname,
                Login = dto.Login,
                Password = dto.Password,
                IsBlocked = dto.IsBlocked,
                UserRoleId = dto.UserRoleDtoId,
                LikeOnRecipes = dto.LikeOnRecipesDto.Cast<LikeOnRecipe>().ToList(),
                BookOfRecipes = dto.BookOfRecipesDto.Cast<BookOfRecipe>().ToList()
            };
        }
    }
}
