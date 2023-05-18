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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public TextBox TbLogin => tbLogin;
        public TextBox TbName => tbName;
        public TextBox TbSurname => tbSurname;
        public TextBox TbPassword => tbPassword;
        public TextBox TbConfirmPassword => tbConfirmPassword;
        
        public Button BtnRegistration => btnRegistration;
        public Button BtnCancel => btnCancel;
    }
}
