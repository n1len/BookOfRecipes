using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record RecipeDto : BaseObjectDto
    {
        public required string Title { get; set; }
        public string Tags { get; set; } = string.Empty;
        public string DescriptionField { get; set; } = string.Empty;

        public required Guid BookOfRecipeDtoId { get; init; }
        public virtual BookOfRecipeDto? BookOfRecipeDto { get; init; }

        public ICollection<LikeOnRecipeDto> LikesOnRecipeDto { get; init; } = new List<LikeOnRecipeDto>();
    }
}
