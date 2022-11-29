using System.Configuration;

using BookOfRecipes.Engine;

namespace BookOfRecipes.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.DoSomeJob(GetConnectionString());
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.
                    ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}