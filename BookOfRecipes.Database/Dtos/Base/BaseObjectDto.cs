namespace BookOfRecipes.Database.Dtos.Base
{
    public record BaseObjectDto
    {
        public Guid Id { get; init; } = Guid.NewGuid();
    }
}
