using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfRecipes.UI.GUI.Forms
{
    public partial class RecipesInBookForm : Form
    {
        public RecipesInBookForm()
        {
            InitializeComponent();
        }

        public Button BtnCreateRecipe => btnCreateRecipe;
        public Button BtnNextPage => btnNextPage;
        public Button BtnPreviousPage => btnPreviousPage;
        public Button BtnRefreshPage => btnRefreshForm;

        public FlowLayoutPanel RecipesInBookPanel => recipesInBookPanel;

        public TextBox TbTitle => tbTitle;
        public TextBox TbDescription => tbDescription;

        public Label LbPage => lbPage;
        public Label LbCollectionIsEmpty => lbCollectionIsEmpty;
    }
}
