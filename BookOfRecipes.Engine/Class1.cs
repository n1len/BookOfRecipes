using BookOfRecipes.Database;
using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Interfaces;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;

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

            UserDto user = new UserDto()
            {
                Name = "TestName",
                Surname = "TestSurname",
                Login = "Test",
                Password = "TestNotEncrypted",
                UserRoleDtoId = Guid.Parse("2281020A-3FDD-4E9D-BBFD-0614B50A586A")
            };
            IUserRepository userRepository = new UserRepository(connectionString);
            userRepository.Create(user);
            BookOfRecipeDto dto = new BookOfRecipeDto() 
            {
                Title= "Title",
                UserDtoId = user.Id,
            };
            IBookOfRecipeRepository bookOfRecipeRepository = new BookOfRecipeRepository(connectionString);
            bookOfRecipeRepository.Create(dto);
        }
    }
}