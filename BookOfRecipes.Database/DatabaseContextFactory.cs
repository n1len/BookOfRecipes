using Microsoft.EntityFrameworkCore;

using BookOfRecipes.Database.Interfaces;

namespace BookOfRecipes.Database
{
    public class DatabaseContextFactory : IDatabaseContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDatabaseContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer(connectionString);

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
