using BookOfRecipes.UI.Validators;
using BookOfRecipes.Database.Dtos.Base;
using BookOfRecipes.UI.GUI.Controls;

namespace BookOfRecipes.UI.Helpers
{
    public class PageLoaderHelper
    {
        private int nextPage;
        private int currentPage;
        private int pageSize;

        private List<BaseObjectDto> itemsOnPage;
        PageLoaderControl pageLoaderControl;

        public PageLoaderHelper(int nextPage, int currentPage, int pageSize, List<BaseObjectDto> itemsOnPage, PageLoaderControl pageLoaderControl)
        {
            this.nextPage = nextPage;
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            this.itemsOnPage = itemsOnPage;
            this.pageLoaderControl = pageLoaderControl;
        }

        public void MoveToPage()
        {
            if (PageValidator.Validate(itemsOnPage.Count, out string errorMessage))
            {
                var panel = pageLoaderControl.Controls.Find("itemsPanel", false).FirstOrDefault();
                if (panel is not null)
                {
                    // panel.Controls.Add()
                }
            }
            else
            {
                throw new InvalidDataException(errorMessage);
            }
        }
    }
}
