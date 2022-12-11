using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;
using System.IO.IsolatedStorage;

namespace BookOfRecipes.UI.Processes
{
    internal class LoginProcess : BaseProcess
    {
        private readonly IUserRepository _userRepository;

        public UserDto User { get; private set; }

        public LoginForm Form;

        public LoginProcess()
        {
            Form = new LoginForm();
            Form.TbPassword.PasswordChar = '*';

            _userRepository = new UserRepository(ConnectionString);
            InitializeHandle();
        }

        public void Start()
        {
            User = SignInUsingToken();
            if (User is null)
            {
                Form.Show();
            }
        }

        public UserDto GetAuthorizedUser()
        {
            return User;
        }

        private void InitializeHandle()
        {
            Form.BtnSignIn.Click += SignIn;
            Form.BtnCancel.Click += Cancel;
        }

        private void UnInitializeHandle()
        {
            Form.BtnSignIn.Click -= SignIn;
            Form.BtnCancel.Click -= Cancel;
        }

        private void SignIn(object sender, EventArgs e)
        {
            var user = _userRepository.GetByLogin(Form.TbLogin.Text);
            try
            {
                if (ValidateUser(user))
                {
                    User = user;
                    _userRepository.CreateIsolatedStorageWithToken(user.Token);
                    DialogResult result = MessageBox.Show("Successfully signed in", "Sign in completed",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        Form.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            UnInitializeHandle();
            Form.Dispose();
        }

        private UserDto SignInUsingToken()
        {
            return _userRepository.GetByToken();
        }

        private bool ValidateUser(UserDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user.Login) ,"Incorrect login, try again");
            }
            if (user.IsBlocked)
            {
                throw new Exception("Account blocked");
            }
            if (user.Password != Form.TbPassword.Text)
            {
                throw new Exception("Wrong password, try again");
            }

            return true;
        }
    }
}
