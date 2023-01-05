using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    public partial class EditForm : Form
    {
        private int _movieIndex;
        private bool _movieEdited = false;
        public EditForm(int index)
        {
            InitializeComponent();
            _movieIndex = index;
        }

        private void EditForm_Load(object sender, EventArgs e) => FillFields();

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!_movieEdited)
            {
                if (MessageBox.Show(
                caption: "Megerősítés",
                text: "Biztosan kilépsz módosítás nélkül?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbMovieTitle.Text))
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

            if (string.IsNullOrWhiteSpace(tbMovieRating.Text))
            {
                Core.ErrorBox("Az 'értékelés' mező kitöltése kötelező!");
                tbMovieRating.Focus();
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
         
            if (MessageBox.Show(
                caption: "Megerősítés",
                text: "Biztosan végrehajtod a módosításokat?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tbMovieRating.Text = tbMovieRating.Text.Replace(',', '.');
                UpdateMovieData();
            }          
        }      

        private void FillFields()
        {
            Core.ManageSQL(true);
            using SqlDataReader rdr = Core.Query($"SELECT title, director, publicationYear, genreId, rating FROM movies WHERE movieid = '{_movieIndex}';");
            while (rdr.Read())
            {
                tbMovieTitle.Text = $"{rdr[0]}";
                tbMovieDirector.Text = $"{rdr[1]}";
                tbMovieYear.Text = $"{rdr[2]}";
                cbMovieGenre.SelectedIndex = (int)(rdr[3]) - 1;
                tbMovieRating.Text = $"{rdr[4]}";
            }
            Core.ManageSQL(false);
        }

        private void UpdateMovieData()
        {
            Core.UpdateData($"UPDATE movies SET title = '{tbMovieTitle.Text}', director = '{tbMovieDirector.Text}', publicationYear = '{tbMovieYear.Text}', genreId = '{cbMovieGenre.SelectedIndex+1}', rating = '{tbMovieRating.Text}' WHERE movieId = '{_movieIndex}';");
            Core.InfoBox("A film adatlapja sikeresen módosítva lett!");
            _movieEdited = true;
            this.Dispose(true);
        }     
    }
}