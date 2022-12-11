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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public TextBox TbLogin => tbLogin;
        public TextBox TbPassword => tbPassword;
        
        public Button BtnSignIn => btnSignIn;
        public Button BtnCancel => btnCancel;
    }
}
