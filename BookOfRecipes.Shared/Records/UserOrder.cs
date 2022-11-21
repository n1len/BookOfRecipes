namespace BookOfRecipes.Shared.Records
{
    public record UserOrder
    {
        public Guid Id { get; } = Guid.NewGuid();

        public required Guid UserRecipesCartId { get; init; }
        public required UserRecipesCart? UserRecipesCart { get; init; }

        public required Guid UserId { get; init; }
        public required User? User { get; init; }
    }
}
