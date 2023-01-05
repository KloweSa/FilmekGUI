namespace FilmekGUI
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMovieTitle = new System.Windows.Forms.TextBox();
            this.tbMovieDirector = new System.Windows.Forms.TextBox();
            this.tbMovieYear = new System.Windows.Forms.TextBox();
            this.tbMovieRating = new System.Windows.Forms.TextBox();
            this.cbMovieGenre = new System.Windows.Forms.ComboBox();
            this.btnEditMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(368, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film adatlapjának módosítása";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FilmekGUI.Properties.Resources.director;
            this.pictureBox2.Location = new System.Drawing.Point(16, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FilmekGUI.Properties.Resources.date;
            this.pictureBox3.Location = new System.Drawing.Point(16, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FilmekGUI.Properties.Resources.genre;
            this.pictureBox4.Location = new System.Drawing.Point(15, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FilmekGUI.Properties.Resources.rating;
            this.pictureBox5.Location = new System.Drawing.Point(15, 228);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilmekGUI.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(16, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rendező:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 148);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Megjelenési év:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(46, 188);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Műfaj:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(46, 228);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Értékelés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Film címe:";
            // 
            // tbMovieTitle
            // 
            this.tbMovieTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMovieTitle.Location = new System.Drawing.Point(217, 73);
            this.tbMovieTitle.Name = "tbMovieTitle";
            this.tbMovieTitle.Size = new System.Drawing.Size(222, 25);
            this.tbMovieTitle.TabIndex = 14;
            this.tbMovieTitle.TabStop = false;
            // 
            // tbMovieDirector
            // 
            this.tbMovieDirector.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMovieDirector.Location = new System.Drawing.Point(217, 108);
            this.tbMovieDirector.Name = "tbMovieDirector";
            this.tbMovieDirector.Size = new System.Drawing.Size(222, 25);
            this.tbMovieDirector.TabIndex = 14;
            this.tbMovieDirector.TabStop = false;
            // 
            // tbMovieYear
            // 
            this.tbMovieYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMovieYear.Location = new System.Drawing.Point(217, 150);
            this.tbMovieYear.MaxLength = 4;
            this.tbMovieYear.Name = "tbMovieYear";
            this.tbMovieYear.Size = new System.Drawing.Size(53, 25);
            this.tbMovieYear.TabIndex = 14;
            this.tbMovieYear.TabStop = false;
            // 
            // tbMovieRating
            // 
            this.tbMovieRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMovieRating.Location = new System.Drawing.Point(217, 228);
            this.tbMovieRating.MaxLength = 3;
            this.tbMovieRating.Name = "tbMovieRating";
            this.tbMovieRating.Size = new System.Drawing.Size(53, 25);
            this.tbMovieRating.TabIndex = 14;
            this.tbMovieRating.TabStop = false;
            // 
            // cbMovieGenre
            // 
            this.cbMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieGenre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMovieGenre.FormattingEnabled = true;
            this.cbMovieGenre.Items.AddRange(new object[] {
            "Akciófilm",
            "Bűnügyi film",
            "Dokumentumfilm",
            "Filmdráma",
            "Filmvígjáték",
            "Horrorfilm",
            "Játékfilm",
            "Kalandfilm",
            "Thriller",
            "Westernfilm"});
            this.cbMovieGenre.Location = new System.Drawing.Point(217, 188);
            this.cbMovieGenre.Name = "cbMovieGenre";
            this.cbMovieGenre.Size = new System.Drawing.Size(162, 25);
            this.cbMovieGenre.TabIndex = 15;
            this.cbMovieGenre.TabStop = false;
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditMovie.Image = global::FilmekGUI.Properties.Resources.save;
            this.btnEditMovie.Location = new System.Drawing.Point(115, 279);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(196, 47);
            this.btnEditMovie.TabIndex = 16;
            this.btnEditMovie.TabStop = false;
            this.btnEditMovie.Text = "Mentés";
            this.btnEditMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 338);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.cbMovieGenre);
            this.Controls.Add(this.tbMovieRating);
            this.Controls.Add(this.tbMovieYear);
            this.Controls.Add(this.tbMovieDirector);
            this.Controls.Add(this.tbMovieTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adatlap módosítás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label2;
        private TextBox tbMovieTitle;
        private TextBox tbMovieDirector;
        private TextBox tbMovieYear;
        private TextBox tbMovieRating;
        private ComboBox cbMovieGenre;
        private Button btnEditMovie;
    }
}