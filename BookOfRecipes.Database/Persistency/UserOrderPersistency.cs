using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserOrderPersistency : PersistencyObject<UserOrder>
    {
        public static UserOrderPersistency Instance => new UserOrderPersistency();

        public override void Create(DatabaseContext context, UserOrder entity)
        {
            context.UserOrders.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, UserOrder entity)
        {
            context.UserOrders.Remove(entity);
            base.SaveChanges(context);
        }

        public override void Update(DatabaseContext context, UserOrder entity)
        {
            context.UserOrders.Update(entity);
            base.SaveChanges(context);
        }

        public override UserOrder GetById(DatabaseContext context, Guid id) => context.UserOrders.FirstOrDefault(x => x.Id == id);
    }
}
