using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Persistency
{
    public class BookOfRecipePersistency : PersistencyObject<BookOfRecipe>
    {
        public override void Create(DatabaseContext context, BookOfRecipe entity)
        {
            context.BookOfRecipes.Add(entity);
            base.SaveChanges(context);
        }

        public override void Delete(DatabaseContext context, BookOfRecipe entity)
        {
            context.BookOfRecipes.Remove(entity);
            base.SaveChanges(context);
        }

        public override void Update(DatabaseContext context, BookOfRecipe entity)
        {
            context.BookOfRecipes.Update(entity);
            base.SaveChanges(context);
        }

        public override BookOfRecipe GetById(DatabaseContext context, Guid id) => context.BookOfRecipes.FirstOrDefault(x => x.Id == id);
    }
}
