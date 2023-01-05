namespace FilmekGUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiMuveletek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAuth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewFilm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovieData = new System.Windows.Forms.DataGridViewImageColumn();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMuveletek,
            this.tsmiSearch,
            this.tsmiClearSearch});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(871, 44);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiMuveletek
            // 
            this.tsmiMuveletek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAuth,
            this.tsmiNewFilm});
            this.tsmiMuveletek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiMuveletek.Image = global::FilmekGUI.Properties.Resources.edit;
            this.tsmiMuveletek.Name = "tsmiMuveletek";
            this.tsmiMuveletek.Size = new System.Drawing.Size(101, 40);
            this.tsmiMuveletek.Text = "Műveletek";
            this.tsmiMuveletek.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiAuth
            // 
            this.tsmiAuth.Image = global::FilmekGUI.Properties.Resources.auth;
            this.tsmiAuth.Name = "tsmiAuth";
            this.tsmiAuth.Size = new System.Drawing.Size(190, 24);
            this.tsmiAuth.Text = "Bejelentkezés";
            this.tsmiAuth.Click += new System.EventHandler(this.tsmiAuth_Click);
            // 
            // tsmiNewFilm
            // 
            this.tsmiNewFilm.Image = global::FilmekGUI.Properties.Resources._new;
            this.tsmiNewFilm.Name = "tsmiNewFilm";
            this.tsmiNewFilm.Size = new System.Drawing.Size(190, 24);
            this.tsmiNewFilm.Text = "Új film felvétele";
            this.tsmiNewFilm.Click += new System.EventHandler(this.tsmiNewFilm_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiSearch.Image = global::FilmekGUI.Properties.Resources.searchMenu;
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(77, 40);
            this.tsmiSearch.Text = "Keresés";
            this.tsmiSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiSearch.Click += new System.EventHandler(this.tsmiSearch_Click);
            // 
            // tsmiClearSearch
            // 
            this.tsmiClearSearch.Image = global::FilmekGUI.Properties.Resources.delete;
            this.tsmiClearSearch.Name = "tsmiClearSearch";
            this.tsmiClearSearch.Size = new System.Drawing.Size(120, 40);
            this.tsmiClearSearch.Text = "Keresés törlése";
            this.tsmiClearSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiClearSearch.Click += new System.EventHandler(this.tsmiClearSearch_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colYear,
            this.colGenre,
            this.colMovieData});
            this.dgvMain.Location = new System.Drawing.Point(12, 62);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(847, 466);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colID.DefaultCellStyle = dataGridViewCellStyle2;
            this.colID.FillWeight = 10F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Cím";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colYear
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colYear.DefaultCellStyle = dataGridViewCellStyle3;
            this.colYear.FillWeight = 31F;
            this.colYear.HeaderText = "Megjelenési év";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colGenre
            // 
            this.colGenre.FillWeight = 45F;
            this.colGenre.HeaderText = "Műfaj";
            this.colGenre.Name = "colGenre";
            this.colGenre.ReadOnly = true;
            // 
            // colMovieData
            // 
            this.colMovieData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMovieData.HeaderText = "Adatlap";
            this.colMovieData.Image = global::FilmekGUI.Properties.Resources.eye;
            this.colMovieData.Name = "colMovieData";
            this.colMovieData.ReadOnly = true;
            this.colMovieData.Width = 67;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(871, 540);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmiMuveletek;
        private ToolStripMenuItem tsmiAuth;
        private ToolStripMenuItem tsmiNewFilm;
        private ToolStripMenuItem tsmiSearch;
        private DataGridView dgvMain;
        private ToolStripMenuItem tsmiClearSearch;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewImageColumn colMovieData;
    }
}