using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class LikeOnRecipePersistency : PersistencyObject<LikeOnRecipe>
    {
        public static LikeOnRecipePersistency Instance => new LikeOnRecipePersistency();

        public override void Create(DatabaseContext context, LikeOnRecipe entity)
        {
            context.LikeOnRecipes.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, LikeOnRecipe entity)
        {
            context.LikeOnRecipes.Remove(entity);
            base.SaveChanges(context);
        }

        public override void Update(DatabaseContext context, LikeOnRecipe entity)
        {
            context.LikeOnRecipes.Update(entity);
            base.SaveChanges(context);
        }

        public override LikeOnRecipe GetById(DatabaseContext context, Guid id) => context.LikeOnRecipes.FirstOrDefault(x => x.Id == id);
    }
}
