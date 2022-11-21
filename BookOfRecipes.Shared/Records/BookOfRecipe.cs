namespace BookOfRecipes.Shared.Records
{
    public record BookOfRecipe
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string Img { get; init; } = string.Empty;

        public Guid UserId { get; init; }
        public User? User { get; init; }

        public ICollection<Recipe> Recipes { get; init; } = new List<Recipe>();
    }
}
