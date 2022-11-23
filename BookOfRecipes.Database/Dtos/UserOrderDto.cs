using BookOfRecipes.Database.Dtos.Base;

namespace BookOfRecipes.Database.Dtos
{
    public record UserOrderDto : BaseObjectDto
    {
        public required Guid UserRecipesCartDtoId { get; init; }
        public virtual UserRecipesCartDto? UserRecipesCartDto { get; init; }

        public required Guid UserDtoId { get; init; }
        public virtual UserDto? UserDto { get; init; }
    }
}
