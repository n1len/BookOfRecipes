namespace BookOfRecipes.UI.Validators
{
    public static class PageValidator
    {
        public static bool Validate(int itemsOnPageCount, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (itemsOnPageCount == 0)
            {
                errorMessage = "Items on the next page is 0";
                return false;
            } 
            return true;
        }
    }
}
