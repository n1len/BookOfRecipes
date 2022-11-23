﻿using BookOfRecipes.Shared.Records.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookOfRecipes.Shared.Records
{
    public record LikeOnRecipe : BaseObject
    {
        public bool IsLiked { get; init; } = true;

        [ForeignKey(name: "RecipeId")]
        public required Guid RecipeId { get; init; }
        public virtual Recipe? Recipe { get; init; }

        [ForeignKey(name: "UserId")]
        public required Guid UserId { get; set; }
        public virtual User? User { get; init; }
    }
}
