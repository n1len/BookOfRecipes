using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class LikeOnRecipeDtoMapper : BaseDtoMapper<LikeOnRecipeDto, LikeOnRecipe>
    {
        public static LikeOnRecipeDtoMapper Mapper => new LikeOnRecipeDtoMapper();

        public override LikeOnRecipeDto MapToDto(LikeOnRecipe record)
        {
            if (record == null)
            {
                return null;
            }

            return new LikeOnRecipeDto() 
            {
                Id = record.Id,
                IsLiked = record.IsLiked,
                RecipeDtoId = record.RecipeId,
                UserDtoId = record.UserId
            };
        }

        public override LikeOnRecipe MapToRecord(LikeOnRecipeDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new LikeOnRecipe()
            {
                Id = dto.Id,
                IsLiked = dto.IsLiked,
                RecipeId = dto.RecipeDtoId,
                UserId = dto.UserDtoId
            };
        }
    }
}
