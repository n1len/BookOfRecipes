namespace BookOfRecipes.Shared.Records
{
    public record User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; init; } = string.Empty;
        public string Surname { get; init; } = string.Empty;
        public string Login { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
        public bool IsBlocked { get; init; } = false;

        public Guid UserRoleId { get; init; }
        public UserRole? UserRole { get; init; }

        public ICollection<LikeOnRecipe> LikeOnRecipes { get; init; } = new List<LikeOnRecipe>();
        public ICollection<BookOfRecipe> BookOfRecipes { get; init; } = new List<BookOfRecipe>();
    }
}
