using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class UserRecipesCartDtoMapper : BaseDtoMapper<UserRecipesCartDto, UserRecipesCart>
    {
        public static UserRecipesCartDtoMapper Mapper => new UserRecipesCartDtoMapper();

        public override UserRecipesCartDto MapToDto(UserRecipesCart record)
        {
            if (record == null)
            {
                return null;
            }

            return new UserRecipesCartDto()
            {
                Id = record.Id,
                RecipesInCartDto = record.RecipesInCart.Cast<RecipeDto>().ToList()
            };
        }

        public override UserRecipesCart MapToRecord(UserRecipesCartDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new UserRecipesCart()
            {
                Id = dto.Id,
                RecipesInCart = dto.RecipesInCartDto.Cast<Recipe>().ToList()
            };
        }
    }
}
