using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class BookOfRecipeDtoMapper : BaseDtoMapper<BookOfRecipeDto, BookOfRecipe>
    {
        public override BookOfRecipeDto MapToDto(BookOfRecipe record)
        {
            if (record == null)
            {
                return null;
            }

            return new BookOfRecipeDto()
            {
                Id = record.Id,
                Title = record.Title,
                Description = record.Description,
                Img = record.Img,
                UserDtoId = record.UserId,
                RecipesDto = record.Recipes.Cast<RecipeDto>().ToList()
            };
        }

        public override BookOfRecipe MapToRecord(BookOfRecipeDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new BookOfRecipe()
            {
                Id = dto.Id,
                Title = dto.Title,
                Description = dto.Description,
                Img = dto.Img,
                UserId = dto.UserDtoId,
                Recipes = dto.RecipesDto.Cast<Recipe>().ToList()
            };
        }
    }
}
