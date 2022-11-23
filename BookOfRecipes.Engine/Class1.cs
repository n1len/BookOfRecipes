using BookOfRecipes.Database;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Shared.Records;
using Microsoft.EntityFrameworkCore;

namespace BookOfRecipes.Engine
{
    public class Class1
    {
        private IDatabaseContextFactory<DatabaseContext> DatabaseContextFactory = new DatabaseContextFactory();

        public void DoSomeJob(string connectionString)
        {
            using (var context = DatabaseContextFactory.CreateDatabaseContext(connectionString))
            {
                UserRole userRole = new UserRole()
                {
                    RoleName = "TestRole"
                };
                context.Add(userRole);
                context.SaveChanges();
            }
        }
    }
}