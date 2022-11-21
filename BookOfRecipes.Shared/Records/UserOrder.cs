namespace BookOfRecipes.Shared.Records
{
    public record UserOrder
    {
        public Guid Id { get; } = Guid.NewGuid();

        public Guid UserRecipesCartId { get; init; }
        public UserRecipesCart? UserRecipesCart { get; init; }

        public Guid UserId { get; init; }
        public User? User { get; init; }
    }
}
