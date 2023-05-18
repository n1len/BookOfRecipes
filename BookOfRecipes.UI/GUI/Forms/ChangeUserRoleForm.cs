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
    public partial class ChangeUserRoleForm : Form
    {
        public ChangeUserRoleForm()
        {
            InitializeComponent();
        }

        public ComboBox UserRolesComboBox => userRolesComboBox;

        public Button BtnChangeUserRole => btnChangeUserRole;
    }
}
