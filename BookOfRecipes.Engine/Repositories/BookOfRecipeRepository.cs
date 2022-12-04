using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;

namespace BookOfRecipes.Engine.Repositories
{
    public class BookOfRecipeRepository : IBookOfRecipeRepository
    {
        public void Create(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Create();
        }

        public void Update(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Update();
        }

        public void Delete(BookOfRecipeDto bookOfRecipeDto)
        {
            bookOfRecipeDto.Delete();
        }

        public BookOfRecipeDto GetById(Guid id)
        {
            return BookOfRecipeDtoExtension.GetById(id);
        }
    }
}
