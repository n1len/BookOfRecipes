using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfRecipes.UI.Processes
{
    internal class ChangeUserRoleProcess : BaseProcess
    {
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUserRepository _userRepository;

        private readonly ChangeUserRoleForm Form;
        private readonly UserDto _userDto;

        public ChangeUserRoleProcess(UserDto userDto) 
        {
            Form = new ChangeUserRoleForm();
            _userRoleRepository = new UserRoleRepository(ConnectionString);
            _userRepository = new UserRepository(ConnectionString);
            _userDto = userDto;

            InitializeHandle();
            InitializeComboBox();
        }

        public void Start()
        {
            Form.Show();
        }

        private void InitializeHandle()
        {
            Form.BtnChangeUserRole.Click += ChangeUserRole;
        }

        private void InitializeComboBox()
        {
            Form.UserRolesComboBox.Items.AddRange(_userRoleRepository.GetAllRoles()
                .Select(x => x.RoleName).ToArray());
            Form.UserRolesComboBox.SelectedIndex = 0;
        }

        private void ChangeUserRole(object sender, EventArgs e)
        {
            var userRole = _userRoleRepository.GetByName(Form.UserRolesComboBox.SelectedItem.ToString());
            _userDto.UserRoleDtoId = userRole.Id;
            _userRepository.Update(_userDto);
        }
    }
}
