using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserDtoExtension
    {
        public static void Create(this UserDto userDto, DatabaseContext context)
        {
            UserPersistency.Instance.Create(context, UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static void Update(this UserDto userDto, DatabaseContext context)
        {
            UserPersistency.Instance.Update(context, UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static void Delete(this UserDto userDto, DatabaseContext context)
        {
            UserPersistency.Instance.Delete(context, UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static UserDto GetById(Guid id, DatabaseContext context)
        {
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetById(context, id));
        }

        public static UserDto GetByToken(string token, DatabaseContext context)
        {
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetByToken(context, token));
        }

        public static UserDto GetByLogin(string login, DatabaseContext context)
        {
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetByLogin(context, login));
        }
    }
}
