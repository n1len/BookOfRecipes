namespace BookOfRecipes.Shared.Records.Base
{
    public record BaseObject
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
