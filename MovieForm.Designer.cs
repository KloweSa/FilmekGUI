namespace FilmekGUI
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.pbMovieIMG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMovieTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMovieDirector = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMovieYear = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMovieGenre = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMovieRating = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbRatingStars = new System.Windows.Forms.PictureBox();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatingStars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnFormClose);
            this.panel1.Controls.Add(this.lbFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnFormClose
            // 
            this.btnFormClose.BackColor = System.Drawing.Color.Red;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFormClose.Location = new System.Drawing.Point(599, 2);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(76, 24);
            this.btnFormClose.TabIndex = 1;
            this.btnFormClose.Text = "Bezárás";
            this.btnFormClose.UseVisualStyleBackColor = false;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbFormTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFormTitle.Location = new System.Drawing.Point(3, 6);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(0, 20);
            this.lbFormTitle.TabIndex = 1;
            this.lbFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pbMovieIMG
            // 
            this.pbMovieIMG.Location = new System.Drawing.Point(194, 47);
            this.pbMovieIMG.Name = "pbMovieIMG";
            this.pbMovieIMG.Size = new System.Drawing.Size(287, 420);
            this.pbMovieIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovieIMG.TabIndex = 1;
            this.pbMovieIMG.TabStop = false;
            this.pbMovieIMG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pbMovieIMG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pbMovieIMG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 497);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film címe:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilmekGUI.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(24, 497);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbMovieTitle
            // 
            this.lbMovieTitle.AutoSize = true;
            this.lbMovieTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMovieTitle.Location = new System.Drawing.Point(176, 497);
            this.lbMovieTitle.Name = "lbMovieTitle";
            this.lbMovieTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMovieTitle.Size = new System.Drawing.Size(0, 24);
            this.lbMovieTitle.TabIndex = 2;
            this.lbMovieTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbMovieTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbMovieTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 534);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rendező:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbMovieDirector
            // 
            this.lbMovieDirector.AutoSize = true;
            this.lbMovieDirector.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMovieDirector.Location = new System.Drawing.Point(167, 534);
            this.lbMovieDirector.Name = "lbMovieDirector";
            this.lbMovieDirector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMovieDirector.Size = new System.Drawing.Size(0, 24);
            this.lbMovieDirector.TabIndex = 2;
            this.lbMovieDirector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbMovieDirector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbMovieDirector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FilmekGUI.Properties.Resources.director;
            this.pictureBox2.Location = new System.Drawing.Point(24, 534);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(55, 574);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Megjelenési év:";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbMovieYear
            // 
            this.lbMovieYear.AutoSize = true;
            this.lbMovieYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMovieYear.Location = new System.Drawing.Point(232, 575);
            this.lbMovieYear.Name = "lbMovieYear";
            this.lbMovieYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMovieYear.Size = new System.Drawing.Size(0, 24);
            this.lbMovieYear.TabIndex = 2;
            this.lbMovieYear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbMovieYear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbMovieYear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FilmekGUI.Properties.Resources.date;
            this.pictureBox3.Location = new System.Drawing.Point(24, 574);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(54, 614);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Műfaj:";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbMovieGenre
            // 
            this.lbMovieGenre.AutoSize = true;
            this.lbMovieGenre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMovieGenre.Location = new System.Drawing.Point(135, 614);
            this.lbMovieGenre.Name = "lbMovieGenre";
            this.lbMovieGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMovieGenre.Size = new System.Drawing.Size(0, 24);
            this.lbMovieGenre.TabIndex = 2;
            this.lbMovieGenre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbMovieGenre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbMovieGenre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FilmekGUI.Properties.Resources.genre;
            this.pictureBox4.Location = new System.Drawing.Point(23, 614);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(54, 654);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Értékelés:";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lbMovieRating
            // 
            this.lbMovieRating.AutoSize = true;
            this.lbMovieRating.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMovieRating.Location = new System.Drawing.Point(167, 655);
            this.lbMovieRating.Name = "lbMovieRating";
            this.lbMovieRating.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMovieRating.Size = new System.Drawing.Size(0, 24);
            this.lbMovieRating.TabIndex = 2;
            this.lbMovieRating.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.lbMovieRating.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.lbMovieRating.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FilmekGUI.Properties.Resources.rating;
            this.pictureBox5.Location = new System.Drawing.Point(23, 654);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // pbRatingStars
            // 
            this.pbRatingStars.Location = new System.Drawing.Point(212, 646);
            this.pbRatingStars.Name = "pbRatingStars";
            this.pbRatingStars.Size = new System.Drawing.Size(54, 37);
            this.pbRatingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRatingStars.TabIndex = 4;
            this.pbRatingStars.TabStop = false;
            this.pbRatingStars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pbRatingStars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pbRatingStars.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Enabled = false;
            this.btnEditMovie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditMovie.Image = global::FilmekGUI.Properties.Resources.editMovie;
            this.btnEditMovie.Location = new System.Drawing.Point(92, 706);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(198, 47);
            this.btnEditMovie.TabIndex = 5;
            this.btnEditMovie.TabStop = false;
            this.btnEditMovie.Text = "Adatlap módosítása";
            this.btnEditMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.Enabled = false;
            this.btnDelMovie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelMovie.Image = global::FilmekGUI.Properties.Resources.delete;
            this.btnDelMovie.Location = new System.Drawing.Point(376, 706);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(198, 47);
            this.btnDelMovie.TabIndex = 5;
            this.btnDelMovie.TabStop = false;
            this.btnDelMovie.Text = "Adatlap törlése";
            this.btnDelMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelMovie.UseVisualStyleBackColor = true;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 765);
            this.Controls.Add(this.btnDelMovie);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.pbRatingStars);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMovieDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMovieYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMovieGenre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbMovieRating);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMovieTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMovieIMG);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRatingStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbFormTitle;
        private Button btnFormClose;
        private PictureBox pbMovieIMG;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbMovieTitle;
        private Label label3;
        private Label lbMovieDirector;
        private PictureBox pictureBox2;
        private Label label5;
        private Label lbMovieYear;
        private PictureBox pictureBox3;
        private Label label7;
        private Label lbMovieGenre;
        private PictureBox pictureBox4;
        private Label label9;
        private Label lbMovieRating;
        private PictureBox pictureBox5;
        private PictureBox pbRatingStars;
        private Button btnEditMovie;
        private Button btnDelMovie;
    }
}