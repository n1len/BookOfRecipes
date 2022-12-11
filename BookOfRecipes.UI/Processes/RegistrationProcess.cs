using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

using System.Security.Cryptography;
using System.Text;

namespace BookOfRecipes.UI.Processes
{
    internal class RegistrationProcess : BaseProcess
    {
        private readonly RegistrationForm Form;
        private readonly IUserRepository userRepository;
        private readonly IUserRoleRepository userRoleRepository;

        public RegistrationProcess()
        {
            Form = new RegistrationForm();
            userRoleRepository = new UserRoleRepository(ConnectionString);
            userRepository = new UserRepository(ConnectionString);
            InitializeHandle();
            InitializeComponents();
        }

        public RegistrationForm Start()
        {
            return Form;
        }

        private void InitializeComponents()
        {
            Form.BtnRegistration.Enabled = false;
            Form.TbPassword.PasswordChar = '*';
            Form.TbConfirmPassword.PasswordChar = '*';
        }

        private void InitializeHandle()
        {
            Form.BtnRegistration.Click += Registration;
            Form.BtnCancel.Click += Cancel;
            Form.TbConfirmPassword.TextChanged += ValidatePasswords;
            Form.TbPassword.TextChanged += ValidatePasswords;
        }

        private void UnInitializeHandle()
        {
            Form.BtnRegistration.Click -= Registration;
            Form.BtnCancel.Click -= Cancel;
            Form.TbConfirmPassword.TextChanged -= ValidatePasswords;
            Form.TbPassword.TextChanged -= ValidatePasswords;
        }

        private void Registration(object sender, EventArgs e)
        {
            if (userRoleRepository.GetByName("User") is null)
            {
                userRoleRepository.Create(new Database.Dtos.UserRoleDto()
                {
                    RoleName = "User"
                });
            }

            userRepository.Create(new Database.Dtos.UserDto()
            {
                Name = Form.TbName.Text,
                Surname = Form.TbSurname.Text,
                Login = Form.TbLogin.Text,
                Password = Form.TbPassword.Text,
                Token = GenerateSecuredToken(),
                UserRoleDtoId = userRoleRepository.GetByName("User").Id
            });

            DialogResult result = MessageBox.Show("Successfully registered", "Registration completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Form.Close();
            }
        }

        private void Cancel(object sender, EventArgs e) 
        {
            UnInitializeHandle();
            Form.Dispose();
        }

        private void ValidatePasswords(object sender, EventArgs e)
        {
            if (Form.TbPassword.Text != Form.TbConfirmPassword.Text)
            {
                Form.BtnRegistration.Enabled = false;
                return;
            }
            Form.BtnRegistration.Enabled = true;
        }

        private string GenerateSecuredToken()
        {
            string secureRandomString = CreateSecureRandomString();
            using (var sha = SHA512.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(secureRandomString);
                var hash = sha.ComputeHash(bytes);
                var hashString = Convert.ToBase64String(hash);

                return hashString;
            }            
        }

        private static string CreateSecureRandomString(int count = 64) =>
            Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
    }
}
