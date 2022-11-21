namespace BookOfRecipes.Shared.Records
{
    public record UserRole
    {
        public Guid Id { get; } = Guid.NewGuid();
        public required string RoleName { get; init; }

        public ICollection<User> Users { get; init; } = new List<User>();
    }
}
