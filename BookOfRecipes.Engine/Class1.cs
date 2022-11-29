using BookOfRecipes.Database;
using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Interfaces;

namespace BookOfRecipes.Engine
{
    public class Class1
    {
        private IDatabaseContextFactory<DatabaseContext> DatabaseContextFactory = new DatabaseContextFactory();

        public void DoSomeJob(string connectionString)
        {
            //using (var context = DatabaseContextFactory.CreateDatabaseContext(connectionString))
            //{
            //    UserRoleDto userRoleDto = new UserRoleDto()
            //    {
            //        RoleName = "TestRole"
            //    };
            //    UserRoleDtoMapper mapper = new UserRoleDtoMapper();
            //    var userRole = mapper.ToRecord(userRoleDto);
            //    context.Add(userRole);
            //    context.SaveChanges();
            //}

            using (var context = DatabaseContextFactory.CreateDatabaseContext(connectionString))
            {
                var userRoles = context.UserRoles.Where(x => x.RoleName == "TestRole").ToList();
                UserRoleDtoMapper mapper = new UserRoleDtoMapper();
                foreach(var userRole1 in userRoles)
                {
                    var mappedRole = mapper.MapToDto(userRole1);
                }
            }
        }
    }
}