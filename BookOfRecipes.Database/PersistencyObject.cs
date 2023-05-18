namespace BookOfRecipes.Database
{
    public abstract class PersistencyObject<T>
    {
        public static string ConnectionString { get; set; } = string.Empty;
        public abstract void Create(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract T GetById(Guid id);
        protected virtual void SaveChanges(DatabaseContext context) => context.SaveChanges();
    }
}