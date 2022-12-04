namespace BookOfRecipes.Database
{
    public abstract class PersistencyObject<T>
    {
        public abstract void Create(DatabaseContext context, T entity);
        public abstract void Update(DatabaseContext context, T entity);
        public abstract void Delete(DatabaseContext context, T entity);
        public abstract T GetById(DatabaseContext context, Guid id);
        protected virtual void SaveChanges(DatabaseContext context) => context.SaveChanges();
    }
}