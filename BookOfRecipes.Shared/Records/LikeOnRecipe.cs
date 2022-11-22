using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record LikeOnRecipe : BaseObject
    {
        public bool IsLiked { get; init; } = true;

        public required Guid RecipeId { get; init; }
        public required Recipe Recipe { get; init; }

        public required Guid UserId { get; init; }
        public required User User { get; init; }
    }
}
