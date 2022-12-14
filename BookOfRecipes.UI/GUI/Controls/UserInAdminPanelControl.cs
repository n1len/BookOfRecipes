using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.Processes;
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
    public partial class UserInAdminPanelControl : UserControl
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUserRepository _userRepository;

        private readonly UserDto _userDto;

        private ChangeUserRoleProcess changeUserRoleProcess;

        public UserInAdminPanelControl(UserDto userDto, string connectionString)
        {
            _userRoleRepository = new UserRoleRepository(connectionString);
            _userRepository = new UserRepository(connectionString);

            _userDto = userDto;

            InitializeComponent();
            lbLogin.Text = _userDto.Login;
            lbRole.Text = _userRoleRepository.GetById(_userDto.UserRoleDtoId).RoleName;
            UpdateBlockButtonText(_userDto.IsBlocked);
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            changeUserRoleProcess = new ChangeUserRoleProcess(_userDto);
            changeUserRoleProcess.Start();
        }

        private void btnChangeBlockedState_Click(object sender, EventArgs e)
        {
            _userDto.IsBlocked = !_userDto.IsBlocked;
            _userRepository.Update(_userDto);
        }

        private void UpdateBlockButtonText(bool isBlocked)
        {
            btnChangeBlockedState.Text = isBlocked ? "Unblock" : "Block";
        }
    }
}
