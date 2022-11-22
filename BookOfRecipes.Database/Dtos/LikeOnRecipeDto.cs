namespace BookOfRecipes.Database.Dtos
{
    public record LikeOnRecipeDto
    {
        public bool IsLiked { get; init; } = true;

        public required Guid RecipeDtoId { get; init; }
        public required RecipeDto RecipeDto { get; init; }

        public required Guid UserDtoId { get; init; }
        public required UserDto UserDto { get; init; }
    }
}
