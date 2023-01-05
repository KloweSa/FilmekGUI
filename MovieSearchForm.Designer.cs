namespace FilmekGUI
{
    partial class MovieSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnByTitle = new System.Windows.Forms.Button();
            this.btnByGenre = new System.Windows.Forms.Button();
            this.btnByYear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchWord = new System.Windows.Forms.TextBox();
            this.pbSearchPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Keresés";
            // 
            // btnByTitle
            // 
            this.btnByTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnByTitle.Location = new System.Drawing.Point(12, 93);
            this.btnByTitle.Name = "btnByTitle";
            this.btnByTitle.Size = new System.Drawing.Size(141, 47);
            this.btnByTitle.TabIndex = 34;
            this.btnByTitle.TabStop = false;
            this.btnByTitle.Text = "Cím szerint";
            this.btnByTitle.UseVisualStyleBackColor = true;
            this.btnByTitle.Click += new System.EventHandler(this.btnByTitle_Click);
            // 
            // btnByGenre
            // 
            this.btnByGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnByGenre.Location = new System.Drawing.Point(187, 93);
            this.btnByGenre.Name = "btnByGenre";
            this.btnByGenre.Size = new System.Drawing.Size(141, 47);
            this.btnByGenre.TabIndex = 34;
            this.btnByGenre.TabStop = false;
            this.btnByGenre.Text = "Műfaj szerint";
            this.btnByGenre.UseVisualStyleBackColor = true;
            this.btnByGenre.Click += new System.EventHandler(this.btnByGenre_Click);
            // 
            // btnByYear
            // 
            this.btnByYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnByYear.Location = new System.Drawing.Point(359, 93);
            this.btnByYear.Name = "btnByYear";
            this.btnByYear.Size = new System.Drawing.Size(141, 47);
            this.btnByYear.TabIndex = 34;
            this.btnByYear.TabStop = false;
            this.btnByYear.Text = "Megjelenési év szerint";
            this.btnByYear.UseVisualStyleBackColor = true;
            this.btnByYear.Click += new System.EventHandler(this.btnByYear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = global::FilmekGUI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(161, 201);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(196, 47);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchWord
            // 
            this.tbSearchWord.Location = new System.Drawing.Point(149, 95);
            this.tbSearchWord.Name = "tbSearchWord";
            this.tbSearchWord.Size = new System.Drawing.Size(232, 23);
            this.tbSearchWord.TabIndex = 36;
            this.tbSearchWord.Visible = false;
            // 
            // pbSearchPic
            // 
            this.pbSearchPic.Location = new System.Drawing.Point(118, 93);
            this.pbSearchPic.Name = "pbSearchPic";
            this.pbSearchPic.Size = new System.Drawing.Size(25, 25);
            this.pbSearchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchPic.TabIndex = 37;
            this.pbSearchPic.TabStop = false;
            this.pbSearchPic.Visible = false;
            // 
            // MovieSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 260);
            this.Controls.Add(this.pbSearchPic);
            this.Controls.Add(this.tbSearchWord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnByYear);
            this.Controls.Add(this.btnByGenre);
            this.Controls.Add(this.btnByTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovieSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.MovieSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnByTitle;
        private Button btnByGenre;
        private Button btnByYear;
        private Button btnSearch;
        private TextBox tbSearchWord;
        private PictureBox pbSearchPic;
    }
}