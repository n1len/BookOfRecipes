using BookOfRecipes.Shared.Records.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOfRecipes.Shared.Records
{
    public record UserOrder : BaseObject
    {
        [ForeignKey(name: "UserRecipesCartId")]
        public required Guid UserRecipesCartId { get; init; }
        public virtual UserRecipesCart? UserRecipesCart { get; init; }

        [ForeignKey(name: "UserId")]
        public required Guid UserId { get; init; }
        public virtual User? User { get; init; }
    }
}
