using BookOfRecipes.Shared.Records.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOfRecipes.Shared.Records
{
    public record Recipe : BaseObject
    {
        public required string Title { get; init; }
        public string Tags { get; init; } = string.Empty;
        public string DescriptionField { get; init; } = string.Empty;

        [ForeignKey(name: "BookOfRecipeId")]
        public required Guid BookOfRecipeId { get; init; }
        public virtual BookOfRecipe? BookOfRecipe { get; init; }

        public ICollection<LikeOnRecipe> LikesOnRecipe { get; init; } = new List<LikeOnRecipe>();
    }
}
