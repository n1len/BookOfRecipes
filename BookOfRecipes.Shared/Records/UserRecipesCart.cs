namespace BookOfRecipes.Shared.Records
{
    public record UserRecipesCart
    {
        public Guid Id { get; } = Guid.NewGuid();

        public ICollection<Recipe> RecipesInCart { get; init; } = new List<Recipe>();
    }
}
