using BookOfRecipes.Shared.Records.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOfRecipes.Shared.Records
{
    public record User : BaseObject
    {
        public required string Name { get; init; }
        public required string Surname { get; init; }
        public required string Login { get; init; }
        public required string Password { get; init; }
        public bool IsBlocked { get; init; } = false;

        [ForeignKey(name: "UserRoleId")]
        public required Guid UserRoleId { get; init; }
        public required UserRole UserRole { get; init; }

        public ICollection<LikeOnRecipe> LikeOnRecipes { get; init; } = new List<LikeOnRecipe>();
        public ICollection<BookOfRecipe> BookOfRecipes { get; init; } = new List<BookOfRecipe>();
    }
}
