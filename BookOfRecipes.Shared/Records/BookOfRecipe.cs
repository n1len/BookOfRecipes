using BookOfRecipes.Shared.Records.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOfRecipes.Shared.Records
{
    public record BookOfRecipe : BaseObject
    {
        public required string Title { get; init; }
        public string Description { get; init; } = string.Empty;
        public string Img { get; init; } = string.Empty;

        [ForeignKey(name: "UserId")]
        public required Guid UserId { get; init; }
        public virtual User? User { get; init; }

        public ICollection<Recipe> Recipes { get; init; } = new List<Recipe>();
    }
}
