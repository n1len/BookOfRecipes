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
        private readonly int ItemsPerPage = 10;

        private readonly IBookOfRecipeRepository _bookOfRecipeRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;

        private readonly MainMenuForm Form;

        private RegistrationProcess registrationProcess;
        private LoginProcess loginProcess;
        private UserAccountProcess userAccountProcess;
        private AdminProcess adminProcess;

        private UserDto _user;

        private int page = 0;

        public MainMenuProcess()
        {
            Form = new MainMenuForm();
            _userRepository = new UserRepository(ConnectionString);
            _bookOfRecipeRepository = new BookOfRecipeRepository(ConnectionString);
            _userRoleRepository = new UserRoleRepository(ConnectionString);

            Form.BtnSignOut.Visible = false;
            Form.BtnToAdminAccount.Visible = false;

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
            FillPanelByPage();
        }

        private void FillPanelByPage()
        {
            var bookOfRecipeDtos = _bookOfRecipeRepository.GetAllBooks()
                .Skip(page * ItemsPerPage).Take(ItemsPerPage);
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
            Form.BtnNextPage.Click += MoveToNextPage;
            Form.BtnPreviousPage.Click += MoveToPreviousPage;
            Form.BtnToAdminAccount.Click += ToAdminAccount;
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
                var userRole = _userRoleRepository.GetById(_user.UserRoleDtoId);
                Form.LbWelcomeMessage.Text = string.Format("Welcome, {0}", _user.Login);
                Form.BtnSignIn.Visible = false;
                Form.BtnRegistration.Visible = false;
                Form.BtnSignOut.Visible = true;
                Form.BtnToUserAccount.Visible = true;
                if (userRole.RoleName == "Admin")
                {
                    Form.BtnToAdminAccount.Visible = true;
                }
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
            Form.BtnToAdminAccount.Visible = false;
        }

        private void Registration(object sender, EventArgs e) 
        {
            registrationProcess = new RegistrationProcess();
            registrationProcess.Start();
        }

        private void ToUserAccount(object sender, EventArgs e) 
        {
            userAccountProcess = new UserAccountProcess(_user);
            userAccountProcess.Start();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            ClearControlWithBooks();
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

        private void ToAdminAccount(object sender, EventArgs e)
        {
            adminProcess = new AdminProcess(_user);
            adminProcess.Start();
        }

        private void ClearControlWithBooks()
        {
            Form.PanelBookOfRecipes.Controls.Clear();
        }

        private void MoveToPage()
        {
            Form.LbPage.Text = "Page: " + (page + 1);
            ClearControlWithBooks();
            FillPanelByPage();
        }
    }
}
