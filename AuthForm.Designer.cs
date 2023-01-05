namespace FilmekGUI
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbAuthUser = new System.Windows.Forms.TextBox();
            this.tbAuthPassword = new System.Windows.Forms.TextBox();
            this.btnAuthEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilmekGUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(37, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FilmekGUI.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(37, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbAuthUser
            // 
            this.tbAuthUser.Location = new System.Drawing.Point(80, 31);
            this.tbAuthUser.MaxLength = 33;
            this.tbAuthUser.Name = "tbAuthUser";
            this.tbAuthUser.PlaceholderText = "Azonosító";
            this.tbAuthUser.Size = new System.Drawing.Size(246, 25);
            this.tbAuthUser.TabIndex = 2;
            this.tbAuthUser.TabStop = false;
            // 
            // tbAuthPassword
            // 
            this.tbAuthPassword.Location = new System.Drawing.Point(80, 75);
            this.tbAuthPassword.MaxLength = 33;
            this.tbAuthPassword.Name = "tbAuthPassword";
            this.tbAuthPassword.PasswordChar = '●';
            this.tbAuthPassword.PlaceholderText = "Jelszó";
            this.tbAuthPassword.Size = new System.Drawing.Size(246, 25);
            this.tbAuthPassword.TabIndex = 2;
            this.tbAuthPassword.TabStop = false;
            // 
            // btnAuthEnter
            // 
            this.btnAuthEnter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthEnter.Location = new System.Drawing.Point(115, 114);
            this.btnAuthEnter.Name = "btnAuthEnter";
            this.btnAuthEnter.Size = new System.Drawing.Size(154, 39);
            this.btnAuthEnter.TabIndex = 3;
            this.btnAuthEnter.TabStop = false;
            this.btnAuthEnter.Text = "Bejelentkezés";
            this.btnAuthEnter.UseVisualStyleBackColor = true;
            this.btnAuthEnter.Click += new System.EventHandler(this.btnAuthEnter_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 165);
            this.Controls.Add(this.btnAuthEnter);
            this.Controls.Add(this.tbAuthPassword);
            this.Controls.Add(this.tbAuthUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbAuthUser;
        private TextBox tbAuthPassword;
        private Button btnAuthEnter;
    }
}