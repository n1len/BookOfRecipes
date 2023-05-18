using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record UserOrderDto : BaseObjectDto
    {
        public required Guid UserRecipesCartDtoId { get; set; }
        public virtual UserRecipesCartDto? UserRecipesCartDto { get; init; }

        public required Guid UserDtoId { get; set; }
        public virtual UserDto? UserDto { get; init; }
    }
}
