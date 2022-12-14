using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserRolePersistency : PersistencyObject<UserRole>
    {
        public static UserRolePersistency Instance => new UserRolePersistency();

        public override void Create(DatabaseContext context, UserRole entity)
        {
            context.UserRoles.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, UserRole entity)
        {
            context.UserRoles.Remove(entity);
            base.SaveChanges(context);
        }

        public override void Update(DatabaseContext context, UserRole entity)
        {
            context.UserRoles.Update(entity);
            base.SaveChanges(context);
        }

        public override UserRole GetById(DatabaseContext context, Guid id) => context.UserRoles.FirstOrDefault(x => x.Id == id);

        public UserRole GetByName(DatabaseContext context, string name) => context.UserRoles.FirstOrDefault(x => x.RoleName == name);

        public IEnumerable<UserRole> GetAllRoles(DatabaseContext context) => context.UserRoles;
    }
}
