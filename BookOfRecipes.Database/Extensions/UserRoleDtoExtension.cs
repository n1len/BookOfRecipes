using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRoleDtoExtension
    {
        public static void Create(this UserRoleDto userRoleDto, string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            UserRolePersistency.Instance.Create(UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static void Update(this UserRoleDto userRoleDto, string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            UserRolePersistency.Instance.Update(UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static void Delete(this UserRoleDto userRoleDto, string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            UserRolePersistency.Instance.Delete(UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static UserRoleDto GetById(Guid id, string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            return UserRoleDtoMapper.Mapper.MapToDto(UserRolePersistency.Instance.GetById(id));
        }

        public static UserRoleDto GetByName(string name, string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            return UserRoleDtoMapper.Mapper.MapToDto(UserRolePersistency.Instance.GetByName(name));
        }

        public static IEnumerable<UserRoleDto> GetAllRoles(string connectionString)
        {
            UserRolePersistency.ConnectionString = connectionString;
            return UserRoleDtoMapper.Mapper.MapToDtos(UserRolePersistency.Instance.GetAllRoles());
        }
    }
}
