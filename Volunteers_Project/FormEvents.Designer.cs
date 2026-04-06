namespace Volunteers_Project
{
    partial class FormEvents
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
            pnTop = new Panel();
            lblUsername = new Label();
            btnLogin = new Button();
            dgvEvent = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvent).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(btnDelete);
            pnTop.Controls.Add(btnEdit);
            pnTop.Controls.Add(btnAdd);
            pnTop.Controls.Add(lblUsername);
            pnTop.Controls.Add(btnLogin);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(10, 10);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(947, 59);
            pnTop.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Right;
            lblUsername.Location = new Point(802, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "label1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(840, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 59);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Выйти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // dgvEvent
            // 
            dgvEvent.AllowUserToAddRows = false;
            dgvEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEvent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEvent.BackgroundColor = Color.White;
            dgvEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvent.ColumnHeadersVisible = false;
            dgvEvent.Dock = DockStyle.Fill;
            dgvEvent.Location = new Point(10, 69);
            dgvEvent.Name = "dgvEvent";
            dgvEvent.ReadOnly = true;
            dgvEvent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvent.Size = new Size(947, 400);
            dgvEvent.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(28, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 37);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(197, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 37);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(373, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 37);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormEvents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 479);
            Controls.Add(dgvEvent);
            Controls.Add(pnTop);
            Name = "FormEvents";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEvents";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private DataGridView dgvEvent;
        private Label lblUsername;
        private Button btnLogin;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}