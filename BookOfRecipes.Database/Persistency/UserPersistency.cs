using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserPersistency : PersistencyObject<User>
    {
        public override void Create(DatabaseContext context, User entity)
        {
            context.Users.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, User entity)
        {
            context.Users.Remove(entity);
            base.SaveChanges(context); ;
        }

        public override void Update(DatabaseContext context, User entity)
        {
            context.Users.Update(entity);
            base.SaveChanges(context);
        }

        public override User GetById(DatabaseContext context, Guid id) => context.Users.FirstOrDefault(x => x.Id == id);
    }
}
