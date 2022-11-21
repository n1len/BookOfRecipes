namespace BookOfRecipes.Shared.Records
{
    public record Recipe
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; init; } = string.Empty;
        public string Tags { get; init; } = string.Empty;
        public string DescriptionField { get; init; } = string.Empty;

        public Guid BookOfRecipeId { get; init; }
        public BookOfRecipe? BookOfRecipe { get; init; }

        public ICollection<LikeOnRecipe> LikeOnRecipes { get; init; } = new List<LikeOnRecipe>();
    }
}
