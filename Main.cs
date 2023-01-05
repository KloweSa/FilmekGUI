using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private void Main_Load(object sender, EventArgs e) => UpdateDGV();
        private void Main_FormClosing(object sender, FormClosingEventArgs e) => Core.ManageSQL(false);

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dgvMain.Columns[e.ColumnIndex].Name == "colMovieData")
            {
                ViewMovieData((int)dgvMain[0, e.RowIndex].Value);
                dgvMain.ClearSelection();
            }
        }

        private void tsmiAuth_Click(object sender, EventArgs e)
        {
            if (Auth.Authorized) Core.InfoBox("Már minden funkció elérhetõ!");
            else
            {
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
        }

        private void tsmiNewFilm_Click(object sender, EventArgs e)
        {
            if (Auth.Authorized)
            {
                this.Hide();
                NewMovieForm newmovie = new NewMovieForm();
                newmovie.ShowDialog();
                this.Show();
                UpdateDGV();
            }
            else Core.ErrorBox("Ehhez a mûvelethez bejelentkezés szükséges!"); 
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieSearchForm searchmovie = new MovieSearchForm();
            searchmovie.ShowDialog();
            this.Show();

            if (Core.SearchFilter is not null) SearchResult();    
        }

        private void tsmiClearSearch_Click(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            Core.ManageSQL(true);
            dgvMain.Rows.Clear();
            using SqlDataReader rdr = Core.Query("SELECT movieId, title, publicationYear, genre FROM movies INNER JOIN genres ON movies.genreId = genres.genreId;");
            while (rdr.Read())
            {
                dgvMain.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr[2],
                    rdr[3]);
            }
            dgvMain.ClearSelection();
            Core.ManageSQL(false);
        }

        private void ViewMovieData(int index)
        {
            this.Hide();
            MovieForm moviepage = new MovieForm(index);
            moviepage.ShowDialog();
            this.Show();
            UpdateDGV();
        }

        private void SearchResult()
        {
            Core.ManageSQL(true);
            if (Core.SearchByTitle)
            {
                dgvMain.Rows.Clear();
                using SqlDataReader rdr = Core.Query($"SELECT movieId, title, publicationYear, genre FROM movies INNER JOIN genres ON movies.genreId = genres.genreId WHERE title LIKE '%{Core.SearchFilter}%';");
                while (rdr.Read())
                {
                    dgvMain.Rows.Add(
                        rdr[0],
                        rdr[1],
                        rdr[2],
                        rdr[3]);
                }
                dgvMain.ClearSelection();
            }
            else if(Core.SearchByGenre)
            {
                dgvMain.Rows.Clear();
                using SqlDataReader rdr = Core.Query($"SELECT movieId, title, publicationYear, genre FROM movies INNER JOIN genres ON movies.genreId = genres.genreId WHERE genre LIKE '%{Core.SearchFilter}%';");
                while (rdr.Read())
                {
                    dgvMain.Rows.Add(
                        rdr[0],
                        rdr[1],
                        rdr[2],
                        rdr[3]);
                }
                dgvMain.ClearSelection();
            }
            else if(Core.SearchByYear)
            {
                dgvMain.Rows.Clear();
                using SqlDataReader rdr = Core.Query($"SELECT movieId, title, publicationYear, genre FROM movies INNER JOIN genres ON movies.genreId = genres.genreId WHERE publicationYear = '{Core.SearchFilter}';");
                while (rdr.Read())
                {
                    dgvMain.Rows.Add(
                        rdr[0],
                        rdr[1],
                        rdr[2],
                        rdr[3]);
                }
                dgvMain.ClearSelection();
            }
            Core.ManageSQL(false);
        }     
    }
}