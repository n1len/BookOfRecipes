using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;
using System.Linq;

namespace BookOfRecipes.Database.DtoMappers
{
    public class RecipeDtoMapper : BaseDtoMapper<RecipeDto, Recipe>
    {
        public static RecipeDtoMapper Mapper => new RecipeDtoMapper();

        public override RecipeDto MapToDto(Recipe record)
        {
            if (record == null)
            {
                return null;
            }

            return new RecipeDto()
            {
                Id = record.Id,
                Title = record.Title,
                Tags = record.Tags,
                DescriptionField = record.DescriptionField,
                BookOfRecipeDtoId = record.BookOfRecipeId,
                LikesOnRecipeDto = record.LikesOnRecipe.Cast<LikeOnRecipeDto>().ToList()
            };
        }

        public override Recipe MapToRecord(RecipeDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Recipe()
            {
                Id = dto.Id,
                Title = dto.Title,
                Tags = dto.Tags,
                DescriptionField = dto.DescriptionField,
                BookOfRecipeId = dto.BookOfRecipeDtoId,
                LikesOnRecipe = dto.LikesOnRecipeDto.Cast<LikeOnRecipe>().ToList()
            };
        }

        public IEnumerable<RecipeDto> MapToDtos(IEnumerable<Recipe> recipes)
        {
            List<RecipeDto> dtos = new List<RecipeDto>();
            foreach (var recipe in recipes)
            {
                dtos.Add(MapToDto(recipe));
            }

            return dtos;
        }
    }
}
