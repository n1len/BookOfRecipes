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
    public partial class UserAccountForm : Form
    {
        public UserAccountForm()
        {
            InitializeComponent();
        }

        public Label LbName => lbName;
        public Label LbSurname => lbSurname;
        public Label LbLogin => lbLogin;
        public Label LbRoleName => lbRoleName;
        public Label LbPage => lbPage;
        public Label LbCollectionIsEmpty => lbCollectionIsEmpty;

        public Button BtnChangePassword => btnChangePassword;
        public Button BtnCreateBookOfRecipe => btnCreateBookOfRecipe;
        public Button BtnRefreshForm => btnRefreshForm;
        public Button BtnNextPage => btnNextPage;
        public Button BtnPreviousPage => btnPreviousPage;

        public TextBox TbNewPassword => tbNewPassword;

        public FlowLayoutPanel UsersBookOfRecipePanel => usersBookOfRecipePanel;
    }
}
