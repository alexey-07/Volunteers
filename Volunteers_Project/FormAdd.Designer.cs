namespace Volunteers_Project
{
    partial class FormAdd
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
            lblName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblPlace = new Label();
            cbPlace = new ComboBox();
            lblCount = new Label();
            txtCount = new TextBox();
            lblUser = new Label();
            cbVolonter = new ComboBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(12, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 21);
            lblName.TabIndex = 6;
            lblName.Text = "Название";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 425);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(592, 45);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(74, 111, 165);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(478, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(74, 111, 165);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(361, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 23);
            txtName.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCategory.Location = new Point(380, 19);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 21);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Категория";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(361, 43);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(223, 23);
            cbCategory.TabIndex = 10;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDate.Location = new Point(12, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(47, 21);
            lblDate.TabIndex = 11;
            lblDate.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(223, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPlace.Location = new Point(380, 93);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(61, 21);
            lblPlace.TabIndex = 13;
            lblPlace.Text = "Место";
            // 
            // cbPlace
            // 
            cbPlace.FormattingEnabled = true;
            cbPlace.Location = new Point(361, 117);
            cbPlace.Name = "cbPlace";
            cbPlace.Size = new Size(223, 23);
            cbPlace.TabIndex = 14;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCount.Location = new Point(12, 171);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(164, 21);
            lblCount.TabIndex = 15;
            lblCount.Text = "Кол-во волонтеров";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(12, 195);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(223, 23);
            txtCount.TabIndex = 16;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUser.Location = new Point(380, 171);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(87, 21);
            lblUser.TabIndex = 17;
            lblUser.Text = "Волонтер";
            // 
            // cbVolonter
            // 
            cbVolonter.FormattingEnabled = true;
            cbVolonter.Location = new Point(361, 195);
            cbVolonter.Name = "cbVolonter";
            cbVolonter.Size = new Size(223, 23);
            cbVolonter.TabIndex = 18;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStatus.Location = new Point(12, 254);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 21);
            lblStatus.TabIndex = 19;
            lblStatus.Text = "Статус";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(12, 278);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(223, 23);
            cbStatus.TabIndex = 20;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 470);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cbVolonter);
            Controls.Add(lblUser);
            Controls.Add(txtCount);
            Controls.Add(lblCount);
            Controls.Add(cbPlace);
            Controls.Add(lblPlace);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDate);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblName);
            Name = "FormAdd";
            Text = "FormAdd";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private Label lblPlace;
        private ComboBox cbPlace;
        private Label lblCount;
        private TextBox txtCount;
        private Label lblUser;
        private ComboBox cbVolonter;
        private Label lblStatus;
        private ComboBox cbStatus;
    }
}