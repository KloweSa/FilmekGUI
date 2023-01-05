using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    public partial class NewMovieForm : Form
    {
        private bool _movieAdded;
        public NewMovieForm()
        {
            InitializeComponent();
            _movieAdded = false;
        }

        private void NewMovieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_movieAdded)
            {
                if (MessageBox.Show(
                caption: "Megerősítés",
                text: "Biztosan kilépsz a film hozzáadása nélkül?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMovieTitle.Text))
            {
                Core.ErrorBox("A 'cím' mező kitöltése kötelező!");
                tbMovieTitle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbMovieDirector.Text))
            {
                Core.ErrorBox("A 'rendező' mező kitöltése kötelező!");
                tbMovieDirector.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbMovieYear.Text))
            {
                Core.ErrorBox("A 'megjelenési év' mező kitöltése kötelező!");
                tbMovieYear.Focus();
                return;
            }

            if (int.TryParse(tbMovieYear.Text, out int year))
            {
                if (year < 1888 || year > DateTime.Now.Year)
                {
                    Core.ErrorBox($"A 'megjelenési év' mező 1888 és {DateTime.Now.Year} között lehet!");
                    tbMovieYear.Focus();
                    return;
                }
            }
            else
            {
                Core.ErrorBox("A 'megjelenési év' mező csak szám lehet!");
                tbMovieYear.Focus();
                return;
            }

            if (cbMovieGenre.SelectedIndex == -1)
            {
                Core.ErrorBox("A 'műfaj' mező kitöltése kötelező!");
                cbMovieGenre.Focus();
                return;
            }

            tbMovieRating.Text = tbMovieRating.Text.Replace('.', ',');
            if (float.TryParse(tbMovieRating.Text, out float rating))
            {
                if (rating < 1 || rating > 5)
                {
                    Core.ErrorBox($"Az 'értékelés' mező 1.0 és 5.0 között lehet!");
                    tbMovieRating.Focus();
                    return;
                }
            }
            else
            {
                Core.ErrorBox("Az 'értékelés' mező csak szám lehet!");
                tbMovieRating.Focus();
                return;
            }

            if (tbMovieYear.Text.Length < 4)
            {
                Core.ErrorBox("A 'megjelenési év' mezőnek 4 számból kell állnia!");
                tbMovieYear.Focus();
                return;
            }
       
            if(MovieExist())
            {
                Core.ErrorBox("Ilyen film már létezik!");
                tbMovieTitle.Focus();
                return;
            }

            if (MessageBox.Show(
                caption: "Megerősítés",
                text: "Biztosan hozzáadod az új filmet?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tbMovieRating.Text = tbMovieRating.Text.Replace(',', '.');
                AddNewMovie();
            }
        }

        private bool MovieExist()
        {
            Core.ManageSQL(true);
            using SqlDataReader rdr = Core.Query($"SELECT movieId FROM movies WHERE title = '{tbMovieTitle.Text}';");
            if (rdr.Read())
            {
                Core.ManageSQL(false);
                return true;
            }
            else
            {
                Core.ManageSQL(false);
                return false;
            } 
        }

        private void AddNewMovie()
        {
            Core.InsertData($"INSERT INTO movies VALUES ('{tbMovieTitle.Text}', '{tbMovieDirector.Text}', {tbMovieYear.Text}, {cbMovieGenre.SelectedIndex+1}, {tbMovieRating.Text}, 'noimage');");
            Core.InfoBox("A film adatlapja sikeresen létrehozva!");
            _movieAdded = true;
            this.Dispose(true);
        }
    }
}