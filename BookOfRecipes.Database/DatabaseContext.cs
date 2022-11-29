using Microsoft.EntityFrameworkCore;

using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<BookOfRecipe> BookOfRecipes { get; set; }
        public DbSet<LikeOnRecipe> LikeOnRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<UserRecipesCart> RecipesCarts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
