namespace BookOfRecipes.Database.Dtos
{
    public record RecipeDto
    {
        public required string Title { get; init; }
        public string Tags { get; init; } = string.Empty;
        public string DescriptionField { get; init; } = string.Empty;

        public required Guid BookOfRecipeDtoId { get; init; }
        public required BookOfRecipeDto BookOfRecipeDto { get; init; }

        public ICollection<LikeOnRecipeDto> LikesOnRecipeDto { get; init; } = new List<LikeOnRecipeDto>();
    }
}
