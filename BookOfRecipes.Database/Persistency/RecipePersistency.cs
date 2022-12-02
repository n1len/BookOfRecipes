using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class RecipePersistency : PersistencyObject<Recipe>
    {
        public override void Create(DatabaseContext context, Recipe entity)
        {
            context.Recipes.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, Recipe entity)
        {
            context.Recipes.Remove(entity);
            base.SaveChanges(context);
        }

        public override void Update(DatabaseContext context, Recipe entity)
        {
            context.Recipes.Update(entity);
            base.SaveChanges(context);
        }

        public override Recipe GetById(DatabaseContext context, Guid id) => context.Recipes.FirstOrDefault(x => x.Id == id);
    }
}
