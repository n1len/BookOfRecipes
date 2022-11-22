namespace BookOfRecipes.Database.Dtos
{
    public record UserRoleDto
    {
        public required string RoleName { get; init; }

        public ICollection<UserDto> UsersDto { get; init; } = new List<UserDto>();
    }
}
