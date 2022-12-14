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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public Button BtnRegistration => btnRegistration;
        public Button BtnSignIn => btnSignIn;
        public Button BtnToUserAccount => btnToUserAccount;
        public Button BtnSignOut => btnSignOut;
        public Button BtnRefreshForm => btnRefreshForm;
        public Button BtnNextPage => btnNextPage;
        public Button BtnPreviousPage => btnPreviousPage;
        public Button BtnToAdminAccount => btnToAdminAccount;

        public Label LbWelcomeMessage => lbWelcomeMessage;
        public Label LbPage => lbPage;

        public FlowLayoutPanel PanelBookOfRecipes => panel1;
    }
}
