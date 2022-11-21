namespace BookOfRecipes.Shared.Records
{
    public record UserRole
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string RoleName { get; init; } = string.Empty;

        public ICollection<User> Users { get; init; } = new List<User>();
    }
}
