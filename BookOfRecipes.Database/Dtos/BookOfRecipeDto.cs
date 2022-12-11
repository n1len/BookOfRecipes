using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record BookOfRecipeDto : BaseObjectDto
    {
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;

        public required Guid UserDtoId { get; init; }
        public virtual UserDto? UserDto { get; init; }

        public ICollection<RecipeDto> RecipesDto { get; init; } = new List<RecipeDto>();
    }
}
