using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class UserRecipesCartPersistency : PersistencyObject<UserRecipesCart>
    {
        public static UserRecipesCartPersistency Instance => new UserRecipesCartPersistency();

        public override void Create(DatabaseContext context, UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(DatabaseContext context, UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }

        public override UserRecipesCart GetById(DatabaseContext context, Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Update(DatabaseContext context, UserRecipesCart entity)
        {
            throw new NotImplementedException();
        }
    }
}
