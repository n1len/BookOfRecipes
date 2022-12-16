using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipes.UI.Processes
{
    internal class AdminProcess : BaseProcess
    {
        private const int ItemsPerPage = 3;

        private readonly IUserRepository _userRepository;
        private readonly AdminForm Form;
        private readonly UserDto _currentUserDto;

        private int page = 0;

        public AdminProcess(UserDto userDto)
        {
            Form = new AdminForm();
            _userRepository = new UserRepository(ConnectionString);
            _currentUserDto = userDto;

            InitializeComponents();
        }

        public void Start()
        {
            Form.ShowDialog();
        }

        private void InitializeComponents()
        {
            InitializeHandle();
            FillPanelByPage();
        }

        private void FillPanelByPage()
        {
            Form.Size = new Size(439, 242);
            Form.LbCollectionIsEmpty.Visible = false;
            Form.PanelWithUserAccounts.Visible = true;
            var users = _userRepository.GetAllUsers().Where(x => x.Id != _currentUserDto.Id)
                .Skip(page * ItemsPerPage).Take(ItemsPerPage);
            if (users.Any() )
            {
                foreach (var user in users)
                {
                    Form.PanelWithUserAccounts.Controls.Add(new UserInAdminPanelControl(user, ConnectionString));
                }
                return;
            }

            Form.Size = new Size(439, 100);
            Form.LbCollectionIsEmpty.Location = new Point(150, 30);
            Form.LbCollectionIsEmpty.Visible = true;
            Form.PanelWithUserAccounts.Visible = false;
        }

        private void InitializeHandle()
        {
            Form.BtnRefreshForm.Click += RefreshForm;
            Form.BtnNextPage.Click += MoveToNextPage;
            Form.BtnPreviousPage.Click += MoveToPreviousPage;
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            ClearControlWithUsers();
            FillPanelByPage();
        }

        private void MoveToNextPage(object sender, EventArgs e)
        {
            page++;
            MoveToPage();
        }

        private void MoveToPreviousPage(object sender, EventArgs e)
        {
            page--;
            if (page <= 0)
            {
                page = 0;
            }
            MoveToPage();
        }

        private void ClearControlWithUsers()
        {
            Form.PanelWithUserAccounts.Controls.Clear();
        }

        private void MoveToPage()
        {
            Form.LbPage.Text = "Page: " + (page + 1);
            ClearControlWithUsers();
            FillPanelByPage();
        }
    }
}
