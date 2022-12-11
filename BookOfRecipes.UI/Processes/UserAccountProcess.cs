using BookOfRecipes.Database.Dtos;
using BookOfRecipes.Engine.Interfaces;
using BookOfRecipes.Engine.Repositories;
using BookOfRecipes.Shared.Enums;
using BookOfRecipes.UI.GUI.Controls;
using BookOfRecipes.UI.GUI.Forms;
using BookOfRecipes.UI.Processes.Base;

namespace BookOfRecipes.UI.Processes
{
    internal class UserAccountProcess : BaseProcess
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IBookOfRecipeRepository _bookOfRecipeRepository;

        private readonly UserDto _user;

        private readonly UserAccountForm Form;

        private const int ItemsPerPage = 5;

        private BookOfRecipeProcess bookOfRecipeProcess;
        private int page = 0;

        public UserAccountProcess(UserDto userDto) 
        {
            _userRepository = new UserRepository(ConnectionString);
            _userRoleRepository = new UserRoleRepository(ConnectionString);
            _bookOfRecipeRepository = new BookOfRecipeRepository(ConnectionString);

            _user = userDto;

            Form = new UserAccountForm();
            Form.TbNewPassword.PasswordChar = '*';

            InitializeComponents();
            InitializeHandle();
        }

        public void Start()
        {
            Form.Show();
        }

        private void InitializeComponents()
        {
            Form.LbName.Text = _user.Name;
            Form.LbSurname.Text = _user.Surname;
            Form.LbLogin.Text = _user.Login;
            Form.LbRoleName.Text = _userRoleRepository.GetById(_user.UserRoleDtoId).RoleName;
            FillPanelByPage();
        }

        private void FillPanelByPage()
        {
            var bookOfRecipeDtosInPage = _bookOfRecipeRepository.GetBookOfRecipeDtosByUserId(_user.Id)
                .Skip(page * ItemsPerPage).Take(ItemsPerPage);
            foreach (var bookOfRecipeDto in bookOfRecipeDtosInPage)
            {
                Form.UsersBookOfRecipePanel.Controls.Add(new BookOfRecipeInUserAccountControl(bookOfRecipeDto, _user));
            }
        }

        private void InitializeHandle()
        {
            Form.BtnChangePassword.Click += ChangePassword;
            Form.BtnCreateBookOfRecipe.Click += CreateBookOfRecipe;
            Form.BtnRefreshForm.Click += RefreshForm;
            Form.BtnNextPage.Click += MoveToNextPage;
            Form.BtnPreviousPage.Click += MoveToPreviousPage;
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            _user.Password = Form.TbNewPassword.Text;
            _userRepository.Update(_user);
        }

        private void CreateBookOfRecipe(object sender, EventArgs e)
        {
            bookOfRecipeProcess = new BookOfRecipeProcess(_user, OperationType.Create);
            bookOfRecipeProcess.Start();
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

        private void ClearControlWithBooks()
        {
            Form.UsersBookOfRecipePanel.Controls.Clear();
        }

        private void MoveToPage()
        {
            Form.LbPage.Text = "Page: " + (page + 1);
            ClearControlWithBooks();
            FillPanelByPage();
        }
    }
}
