using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record UserRecipesCartDto : BaseObjectDto
    {
        public ICollection<RecipeDto> RecipesInCartDto { get; init; } = new List<RecipeDto>();
    }
}
