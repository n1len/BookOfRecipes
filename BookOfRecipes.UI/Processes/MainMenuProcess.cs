using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class MainMenuProcess : BaseProcess
    {
        private readonly IBookOfRecipeRepository _bookOfRecipeRepository;
        private readonly IUserRepository _userRepository;

        private readonly MainMenuForm Form;

        private readonly List<BookOfRecipeDto> _bookOfRecipeDtos = new List<BookOfRecipeDto>();

        private RegistrationProcess registrationProcess;
        private LoginProcess loginProcess;
        private UserAccountProcess userAccountProcess;

        private UserDto _user;

        public MainMenuProcess()
        {
            Form = new MainMenuForm();
            _userRepository = new UserRepository(ConnectionString);
            _bookOfRecipeRepository = new BookOfRecipeRepository(ConnectionString);

            Form.BtnSignOut.Visible = false;

            if (_user is null)
            {
                Form.BtnToUserAccount.Visible = false;
            }

            InitializeComponents();
        }

        public MainMenuForm Start()
        {
            return Form;
        }

        private void InitializeComponents()
        {
            InitializeHandle();
            FillPanel();
        }

        private void FillPanel()
        {
            var bookOfRecipeDtos = _bookOfRecipeRepository.GetAllBooks();
            foreach (var book in bookOfRecipeDtos)
            {
                Form.PanelBookOfRecipes.Controls.Add(new BookOfRecipeInfoControl(book));
            }
        }

        private void InitializeHandle() 
        {
            Form.BtnSignIn.Click += Login;
            Form.BtnRegistration.Click += Registration;
            Form.BtnToUserAccount.Click += ToUserAccount;
            Form.BtnSignOut.Click += SignOut;
            Form.BtnRefreshForm.Click += RefreshForm;
        }

        private void Login(object sender, EventArgs e) 
        {
            loginProcess = new LoginProcess();
            loginProcess.Start();
            if (loginProcess.User != null)
            {
                OnUserSignedIn(sender, e);
            }
            loginProcess.Form.FormClosed += OnUserSignedIn;
        }

        private void OnUserSignedIn(object sender, EventArgs e)
        {
            _user = loginProcess.GetAuthorizedUser();
            if (_user != null)
            {
                Form.LbWelcomeMessage.Text = string.Format("Welcome, {0}", _user.Login);
                Form.BtnSignIn.Visible = false;
                Form.BtnRegistration.Visible = false;
                Form.BtnSignOut.Visible = true;
                Form.BtnToUserAccount.Visible = true;
            }
        }

        private void SignOut(object sender, EventArgs e)
        {
            _user = null;
            _userRepository.DeleteIsolatedStorage();
            Form.LbWelcomeMessage.Text = string.Empty;
            Form.BtnSignIn.Visible = true;
            Form.BtnRegistration.Visible = true;
            Form.BtnSignOut.Visible = false;
            Form.BtnToUserAccount.Visible = false;
        }

        private void Registration(object sender, EventArgs e) 
        {
            registrationProcess = new RegistrationProcess();
            registrationProcess.Start().Show();
        }

        private void ToUserAccount(object sender, EventArgs e) 
        {
            userAccountProcess = new UserAccountProcess(_user);
            userAccountProcess.Start();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            _bookOfRecipeDtos.Clear();
            Form.PanelBookOfRecipes.Controls.Clear();
            FillPanel();
        }
    }
}
