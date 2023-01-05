using FilmekGUI.Properties;

namespace FilmekGUI
{
    public partial class MovieSearchForm : Form
    {
        public MovieSearchForm() => InitializeComponent();

        private void MovieSearchForm_Load(object sender, EventArgs e)
        {
            Core.SearchFilter = null;
            Core.SearchByTitle = false;
            Core.SearchByGenre = false;
            Core.SearchByYear = false;
        }
       
        private void btnByTitle_Click(object sender, EventArgs e) => UpdateForm(1);
        private void btnByGenre_Click(object sender, EventArgs e) => UpdateForm(2);
        private void btnByYear_Click(object sender, EventArgs e) => UpdateForm(3);

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSearchWord.Text))
            {
                Core.ErrorBox("A keresési mező nem lehet üres!");
                tbSearchWord.Focus();
                return;
            }

            if(Core.SearchByYear)
            {
                if (int.TryParse(tbSearchWord.Text, out int year))
                {
                    if (year < 1888 || year > DateTime.Now.Year)
                    {
                        Core.ErrorBox($"A megjelenési év 1888 és {DateTime.Now.Year} között lehet!");
                        tbSearchWord.Focus();
                        return;
                    }
                }
                else
                {
                    Core.ErrorBox("A megjelenési év csak szám lehet!");
                    tbSearchWord.Focus();
                    return;
                }
            }         
            Core.SearchFilter = Convert.ToString(tbSearchWord.Text);
            this.Dispose();
        }

        private void UpdateForm(int searchType)
        {
            btnByTitle.Visible = false;
            btnByGenre.Visible = false;
            btnByYear.Visible = false;

            btnSearch.Visible = true;
            tbSearchWord.Visible = true;
            pbSearchPic.Visible = true;

            switch (searchType)
            {
                case 1:
                    pbSearchPic.Image = Resources.title;
                    tbSearchWord.PlaceholderText = "Keresés film cím szerint...";
                    Core.SearchByTitle = true;
                    break;
                case 2:
                    pbSearchPic.Image = Resources.genre;
                    tbSearchWord.PlaceholderText = "Keresés műfaj szerint...";
                    Core.SearchByGenre = true;
                    break;
                case 3:
                    pbSearchPic.Image = Resources.date;
                    tbSearchWord.PlaceholderText = "Keresés megjelenési év szerint...";
                    Core.SearchByYear = true;
                    break;
                default:
                    Core.ErrorBox("Hiba történt a program használata során.");
                    break;
            }
        }       
    }
}