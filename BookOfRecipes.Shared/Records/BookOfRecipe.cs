﻿using BookOfRecipes.Shared.Records.Base;

namespace BookOfRecipes.Shared.Records
{
    public record BookOfRecipe : BaseObject
    {
        public required string Title { get; init; }
        public string Description { get; init; } = string.Empty;
        public string Img { get; init; } = string.Empty;

        public required Guid UserId { get; init; }
        public required User User { get; init; }

        public ICollection<Recipe> Recipes { get; init; } = new List<Recipe>();
    }
}
