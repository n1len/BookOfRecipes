using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRoleDtoExtension
    {
        public static void Create(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            UserRolePersistency.Instance.Create(context, UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static void Update(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            UserRolePersistency.Instance.Update(context, UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static void Delete(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            UserRolePersistency.Instance.Delete(context, UserRoleDtoMapper.Mapper.MapToRecord(userRoleDto));
        }

        public static UserRoleDto GetById(Guid id, DatabaseContext context)
        {
            return UserRoleDtoMapper.Mapper.MapToDto(UserRolePersistency.Instance.GetById(context, id));
        }

        public static UserRoleDto GetByName(string name, DatabaseContext context)
        {
            return UserRoleDtoMapper.Mapper.MapToDto(UserRolePersistency.Instance.GetByName(context, name));
        }
    }
}
