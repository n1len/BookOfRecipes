using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record UserRecipesCart : BaseObject
    {
        public ICollection<Recipe> RecipesInCart { get; init; } = new List<Recipe>();
    }
}
