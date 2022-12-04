using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserRolePersistency : PersistencyObject<UserRole>
    {
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
    }
}
