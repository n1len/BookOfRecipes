using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record LikeOnRecipeDto : BaseObjectDto
    {
        public bool IsLiked { get; set; } = true;

        public required Guid RecipeDtoId { get; set; }
        public virtual RecipeDto? RecipeDto { get; init; }

        public required Guid UserDtoId { get; set; }
        public virtual UserDto? UserDto { get; init; }
    }
}
