using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record LikeOnRecipeDto : BaseObjectDto
    {
        public bool IsLiked { get; init; } = true;

        public required Guid RecipeDtoId { get; init; }
        public virtual RecipeDto? RecipeDto { get; init; }

        public required Guid UserDtoId { get; init; }
        public virtual UserDto? UserDto { get; init; }
    }
}
