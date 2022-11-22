namespace BookOfRecipes.Database.Dtos
{
    public record BookOfRecipeDto
    {
        public required string Title { get; init; }
        public string Description { get; init; } = string.Empty;
        public string Img { get; init; } = string.Empty;

        public required Guid UserDtoId { get; init; }
        public required UserDto UserDto { get; init; }

        public ICollection<RecipeDto> RecipesDto { get; init; } = new List<RecipeDto>();
    }
}
