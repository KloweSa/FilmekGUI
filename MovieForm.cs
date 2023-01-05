using FilmekGUI.Properties;
using Microsoft.Data.SqlClient;

namespace FilmekGUI
{
    public partial class MovieForm : Form
    {
        private int _movieIndex;
        public MovieForm(int index)
        {
            InitializeComponent();
            _movieIndex = index;
        }

        #region árnyék + form mozgatás
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;
        #endregion

        private void btnFormClose_Click(object sender, EventArgs e) => this.Dispose(true);

        private void MovieForm_Load(object sender, EventArgs e)
        {
            if(Auth.Authorized)
            {
                btnEditMovie.Enabled = true;
                btnDelMovie.Enabled = true;
            }
            UpdateMoviePage();
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            if (!Auth.Authorized) return;

            this.Hide();
            EditForm editMovie = new EditForm(_movieIndex);
            editMovie.ShowDialog();
            this.Show();
            UpdateMoviePage();
        }

        private void btnDelMovie_Click(object sender, EventArgs e)
        {
            if (!Auth.Authorized) return;

            if (MessageBox.Show(
                caption: "Megerősítés",
                text: "Biztosan törölni szeretnéd a film adatlapját?",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteMovie();
            }
        }

        private void UpdateMoviePage()
        {
            Core.ManageSQL(true);
            using SqlDataReader rdr = Core.Query($"SELECT title, director, publicationYear, genre, rating, img FROM movies INNER JOIN genres ON movies.genreId = genres.genreId WHERE movieid = '{_movieIndex}';");
            while (rdr.Read())
            {
                lbFormTitle.Text = $"{rdr[0]} adatlapja";
                lbMovieTitle.Text = $"{rdr[0]}";
                lbMovieDirector.Text = $"{rdr[1]}";
                lbMovieYear.Text = $"{rdr[2]}";
                lbMovieGenre.Text = $"{rdr[3]}";
                lbMovieRating.Text = $"{rdr[4]}";

                pbMovieIMG.Image = Resources.ResourceManager.GetObject($"{rdr[5]}") as Image;
                RatingStar((double)rdr[4]);
            }
            Core.ManageSQL(false);
        }

        private void RatingStar(double rating)
        {
            if(rating < 1.5)
            {
                pbRatingStars.Image = Resources.egy;
                pbRatingStars.Size = new System.Drawing.Size(54, 37);
            }
            else if (rating >= 1.5 && rating < 2)
            {
                pbRatingStars.Image = Resources.egy_f;
                pbRatingStars.Size = new System.Drawing.Size(91, 37);
            }
            else if (rating >= 2 && rating < 2.5)
            {
                pbRatingStars.Image = Resources.ketto;
                pbRatingStars.Size = new System.Drawing.Size(91, 37);
            }
            else if (rating >= 2.5 && rating < 3)
            {
                pbRatingStars.Image = Resources.ketto_f;
                pbRatingStars.Size = new System.Drawing.Size(133, 37);
            }
            else if(rating >= 3 && rating < 3.5)
            {
                pbRatingStars.Image = Resources.harom;
                pbRatingStars.Size = new System.Drawing.Size(133, 37);
            }
            else if(rating >= 3.5 && rating < 4)
            {
                pbRatingStars.Image = Resources.harom_f;
                pbRatingStars.Size = new System.Drawing.Size(181, 37);
            }
            else if (rating >= 4 && rating < 4.5)
            {
                pbRatingStars.Image = Resources.negy;
                pbRatingStars.Size = new System.Drawing.Size(181, 37);
            }
            else if(rating >= 4.5 && rating < 5)
            {
                pbRatingStars.Image = Resources.negy_f;
                pbRatingStars.Size = new System.Drawing.Size(203, 37);
            }
            else if(rating >= 5)
            {
                pbRatingStars.Image = Resources.ot;
                pbRatingStars.Size = new System.Drawing.Size(203, 37);
            }
        }

        private void DeleteMovie()
        {
            Core.DeleteData($"DELETE FROM movies WHERE movieId = '{_movieIndex}';");
            Core.InfoBox($"A(z) '{lbMovieTitle.Text}' című film sikeresen törölve lett!");
            this.Dispose(true);
        }
    }
}