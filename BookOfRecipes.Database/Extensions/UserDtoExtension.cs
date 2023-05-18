using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserDtoExtension
    {
        public static void Create(this UserDto userDto, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            UserPersistency.Instance.Create(UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static void Update(this UserDto userDto, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            UserPersistency.Instance.Update(UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static void Delete(this UserDto userDto, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            UserPersistency.Instance.Delete(UserDtoMapper.Mapper.MapToRecord(userDto));
        }

        public static UserDto GetById(Guid id, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetById(id));
        }

        public static UserDto GetByToken(string token, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetByToken(token));
        }

        public static UserDto GetByLogin(string login, string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            return UserDtoMapper.Mapper.MapToDto(UserPersistency.Instance.GetByLogin(login));
        }

        public static IEnumerable<UserDto> GetAllUsers(string connectionString)
        {
            UserPersistency.ConnectionString = connectionString;
            return UserDtoMapper.Mapper.MapToDtos(UserPersistency.Instance.GetAllUsers());
        }
    }
}
