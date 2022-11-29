using System.ComponentModel.DataAnnotations;

namespace BookOfRecipes.Shared.Records.Base
{
    public record BaseObject
    {
        [Key]
        public Guid Id { get; init; } = Guid.NewGuid();
    }
}
