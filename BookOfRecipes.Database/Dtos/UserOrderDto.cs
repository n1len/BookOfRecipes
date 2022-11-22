namespace BookOfRecipes.Database.Dtos
{
    public record UserOrderDto
    {
        public required Guid UserRecipesCartDtoId { get; init; }
        public required UserRecipesCartDto UserRecipesCartDto { get; init; }

        public required Guid UserDtoId { get; init; }
        public required UserDto UserDto { get; init; }
    }
}
