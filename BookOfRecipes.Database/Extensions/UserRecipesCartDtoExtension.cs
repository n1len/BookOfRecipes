using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRecipesCartDtoExtension
    {
        public static void Create(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            UserRecipesCartPersistency.Instance.Create(context, UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Update(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            UserRecipesCartPersistency.Instance.Update(context, UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Delete(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            UserRecipesCartPersistency.Instance.Delete(context, UserRecipesCartDtoMapper.Mapper.MapToRecord(userRecipesCartDto));
        }

        public static UserRecipesCartDto GetById(Guid id, DatabaseContext context)
        {
            return UserRecipesCartDtoMapper.Mapper.MapToDto(UserRecipesCartPersistency.Instance.GetById(context, id));
        }
    }
}
