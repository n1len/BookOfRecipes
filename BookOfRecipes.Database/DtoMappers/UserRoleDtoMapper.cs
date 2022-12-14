using BookOfRecipes.Database.DtoMappers.Base;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.DtoMappers
{
    public class UserRoleDtoMapper : BaseDtoMapper<UserRoleDto, UserRole>
    {
        public static UserRoleDtoMapper Mapper => new UserRoleDtoMapper();

        public override UserRoleDto MapToDto(UserRole record)
        {
            if (record == null)
            {
                return null;
            }

            return new UserRoleDto()
            {
                Id = record.Id,
                RoleName = record.RoleName,
                UsersDto = record.Users.Cast<UserDto>().ToList()
            };
        }

        public override UserRole MapToRecord(UserRoleDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new UserRole()
            {
                Id = dto.Id,
                RoleName = dto.RoleName,
                Users = dto.UsersDto.Cast<User>().ToList()
            };
        }

        public IEnumerable<UserRoleDto> MapToDtos(IEnumerable<UserRole> roles) 
        {
            List<UserRoleDto> dtos = new List<UserRoleDto>();
            foreach (var role in roles)
            {
                dtos.Add(MapToDto(role));
            }

            return dtos;
        }
    }
}
