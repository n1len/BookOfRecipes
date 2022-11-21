namespace BookOfRecipes.Shared.Records
{
    public record LikeOnRecipe
    {
        public Guid Id { get; } = Guid.NewGuid();
        public bool IsLiked { get; init; } = true;

        public Guid RecipeId { get; init; }
        public Recipe? Recipe { get; init; }

        public Guid UserId { get; init; }
        public User? User { get; init; }
    }
}
