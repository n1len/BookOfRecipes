using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record UserDto : BaseObjectDto
    {
        public required string Name { get; init; }
        public required string Surname { get; init; }
        public required string Login { get; init; }
        public required string Password { get; set; }
        public required string Token { get; init; }
        public bool IsBlocked { get; set; } = false;

        public required Guid UserRoleDtoId { get; set; }
        public virtual UserRoleDto? UserRoleDto { get; init; }

        public ICollection<LikeOnRecipeDto> LikeOnRecipesDto { get; init; } = new List<LikeOnRecipeDto>();
        public ICollection<BookOfRecipeDto> BookOfRecipesDto { get; init; } = new List<BookOfRecipeDto>();
    }
}
