using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.Processes;

namespace BookOfRecipes.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Fcing bastard u must create an unit tests!

            BookOfRecipeRepository repo = new BookOfRecipeRepository("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=TestDatabase; Trusted_Connection=True;");
            BookOfRecipeDto bookOfRecipeDto = new BookOfRecipeDto()
            {
                Title = "test",
                UserDtoId = Guid.Parse("B3D804DA-9E5D-4BBF-8AB9-2E1654298758")
            };
            repo.CreateForTest(bookOfRecipeDto);

            var mainMenuProcess = new MainMenuProcess();
            Application.Run(mainMenuProcess.Start());
        }
    }
}