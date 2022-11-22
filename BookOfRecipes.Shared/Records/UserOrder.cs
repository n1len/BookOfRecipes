using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record UserOrder : BaseObject
    {
        public required Guid UserRecipesCartId { get; init; }
        public required UserRecipesCart UserRecipesCart { get; init; }

        public required Guid UserId { get; init; }
        public required User User { get; init; }
    }
}
