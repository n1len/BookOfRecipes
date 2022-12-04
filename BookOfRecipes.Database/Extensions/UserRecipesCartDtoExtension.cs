using BookOfRecipes.Database.DtoMappers;
using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Database.Persistency;
using BookOfRecipes.Shared.Records;

namespace BookOfRecipes.Database.Extensions
{
    public static class UserRecipesCartDtoExtension
    {
        private static readonly UserRecipesCartDtoMapper _mapper = new UserRecipesCartDtoMapper();
        private static readonly PersistencyObject<UserRecipesCart> _persistencyObject = new UserRecipesCartPersistency();

        public static void Create(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            _persistencyObject.Create(context, _mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Update(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            _persistencyObject.Update(context, _mapper.MapToRecord(userRecipesCartDto));
        }

        public static void Delete(this UserRecipesCartDto userRecipesCartDto, DatabaseContext context)
        {
            _persistencyObject.Delete(context, _mapper.MapToRecord(userRecipesCartDto));
        }

        public static UserRecipesCartDto GetById(Guid id, DatabaseContext context)
        {
            return _mapper.MapToDto(_persistencyObject.GetById(context, id));
        }
    }
}
