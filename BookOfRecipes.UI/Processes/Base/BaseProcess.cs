using BookOfRecipes.Database.Dtos;
using System.Configuration;

namespace BookOfRecipes.UI.Processes.Base
{
    internal class BaseProcess
    {
        public string ConnectionString => ConfigurationManager.
                    ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
