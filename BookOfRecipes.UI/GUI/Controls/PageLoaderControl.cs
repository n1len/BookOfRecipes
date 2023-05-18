using BookOfRecipes.Database.Dtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfRecipes.UI.GUI.Controls
{
    public partial class PageLoaderControl : UserControl
    {
        public PageLoaderControl()
        {
            InitializeComponent();
        }

        public PageLoaderControl(ICollection<BaseObjectDto> itemsForPanel) : base()
        {

        }
    }
}
