namespace BookOfRecipes.Database.Dtos
{
    public record UserRecipesCartDto
    {
        public ICollection<RecipeDto> RecipesInCartDto { get; init; } = new List<RecipeDto>();
    }
}
