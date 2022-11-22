using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record Recipe : BaseObject
    {
        public required string Title { get; init; }
        public string Tags { get; init; } = string.Empty;
        public string DescriptionField { get; init; } = string.Empty;

        public required Guid BookOfRecipeId { get; init; }
        public required BookOfRecipe BookOfRecipe { get; init; }

        public ICollection<LikeOnRecipe> LikeOnRecipes { get; init; } = new List<LikeOnRecipe>();
    }
}
