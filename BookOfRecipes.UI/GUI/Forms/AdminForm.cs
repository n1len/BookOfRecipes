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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public Button BtnNextPage => btnNextPage;
        public Button BtnPreviousPage => btnPreviousPage;
        public Button BtnRefreshForm => btnRefreshForm;

        public FlowLayoutPanel PanelWithUserAccounts => panelWithUserAccounts;

        public Label LbPage => lbPage;
        public Label LbCollectionIsEmpty => lbCollectionIsEmpty;
    }
}
