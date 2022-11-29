using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record UserRole : BaseObject
    {
        public required string RoleName { get; init; }

        public ICollection<User> Users { get; init; } = new List<User>();
    }
}
