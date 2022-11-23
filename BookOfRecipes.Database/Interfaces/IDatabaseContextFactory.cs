using Microsoft.Extensions.Configuration;

namespace BookOfRecipes.Database.Interfaces
{
    public interface IDatabaseContextFactory<T>
    {
        public T CreateDatabaseContext(string connectionString);
    }
}
