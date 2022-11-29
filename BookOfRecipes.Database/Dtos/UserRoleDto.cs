using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record UserRoleDto : BaseObjectDto
    {
        public required string RoleName { get; init; }

        public ICollection<UserDto> UsersDto { get; init; } = new List<UserDto>();
    }
}
