namespace BookOfRecipes.Database.DtoMappers.Base
{
    public abstract class BaseDtoMapper<T, U>
        where T : class
        where U : class
    {
        public abstract T MapToDto(U record);
        public abstract U MapToRecord(T dto);
    }
}
