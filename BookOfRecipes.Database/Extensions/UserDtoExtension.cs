using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserDtoExtension
    {
        private static readonly UserDtoMapper _mapper = new UserDtoMapper();
        private static readonly PersistencyObject<User> _persistencyObject = new UserPersistency();

        public static void Create(this UserDto userDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(userDto));
        }

        public static void Update(this UserDto userDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(userDto));
        }

        public static void Delete(this UserDto userDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(userDto));
        }

        public static UserDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
