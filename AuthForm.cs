namespace FilmekGUI
{
    public partial class AuthForm : Form
    {
        public AuthForm() => InitializeComponent();

        private void btnAuthEnter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAuthUser.Text))
            {
                Core.ErrorBox("Az 'azonosító' mező kitöltése kötelező!");
                tbAuthUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbAuthPassword.Text))
            {
                Core.ErrorBox("A 'jelszó' mező kitöltése kötelező!");
                tbAuthPassword.Focus();
                return;
            }

            if(Auth.Authorization(tbAuthUser.Text, tbAuthPassword.Text)) this.Dispose(true);
        }
    }
}