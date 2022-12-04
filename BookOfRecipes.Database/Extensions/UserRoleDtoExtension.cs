using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRoleDtoExtension
    {
        private static readonly UserRoleDtoMapper _mapper = new UserRoleDtoMapper();
        private static readonly PersistencyObject<UserRole> _persistencyObject = new UserRolePersistency();

        public static void Create(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(userRoleDto));
        }

        public static void Update(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(userRoleDto));
        }

        public static void Delete(this UserRoleDto userRoleDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(userRoleDto));
        }

        public static UserRoleDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
