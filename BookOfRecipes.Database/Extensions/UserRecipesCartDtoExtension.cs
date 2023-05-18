using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRecipesCartDtoExtension
    {
        public static void Create(this UserRecipesCartDto userRecipesCartDto, string connectionString)
        {
            UserRecipesCartPersistency.ConnectionString = connectionString;
            UserRecipesCartPersistency.Instance.Create(UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Update(this UserRecipesCartDto userRecipesCartDto, string connectionString)
        {
            UserRecipesCartPersistency.ConnectionString = connectionString;
            UserRecipesCartPersistency.Instance.Update(UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Delete(this UserRecipesCartDto userRecipesCartDto, string connectionString)
        {
            UserRecipesCartPersistency.ConnectionString = connectionString;
            UserRecipesCartPersistency.Instance.Delete(UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static UserRecipesCartDto GetById(Guid id, string connectionString)
        {
            UserRecipesCartPersistency.ConnectionString = connectionString;
            return UserRecipesCartDtoMapper.Mapper.MapToDto(UserRecipesCartPersistency.Instance.GetById(id));
        }
    }
}
