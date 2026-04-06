namespace Volunteers_Project
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnMain = new Panel();
            pctImage = new PictureBox();
            btnGuest = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            lblLogin = new Label();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctImage).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(pctImage);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(lblPassword);
            pnMain.Controls.Add(lblLogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(10, 10);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(333, 384);
            pnMain.TabIndex = 0;
            // 
            // pctImage
            // 
            pctImage.Image = (Image)resources.GetObject("pctImage.Image");
            pctImage.InitialImage = (Image)resources.GetObject("pctImage.InitialImage");
            pctImage.Location = new Point(119, 13);
            pctImage.Name = "pctImage";
            pctImage.Size = new Size(100, 63);
            pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            pctImage.TabIndex = 9;
            pctImage.TabStop = false;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(76, 175, 80);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnGuest.Location = new Point(82, 309);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(170, 36);
            btnGuest.TabIndex = 8;
            btnGuest.Text = "Гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(82, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 36);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.Location = new Point(134, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 21);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Пароль";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLogin.Location = new Point(134, 103);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(61, 21);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Логин";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(82, 137);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(170, 23);
            txtLogin.TabIndex = 3;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 404);
            Controls.Add(pnMain);
            Name = "FormLogin";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private PictureBox pctImage;
        private Button btnGuest;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblLogin;
    }
}