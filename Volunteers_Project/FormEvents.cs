using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Volunteers_Project.Models;
using Volunteers_Project.Properties;
using static System.Reflection.Metadata.BlobBuilder;

namespace Volunteers_Project
{
    public partial class FormEvents : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormEvents(User currentUser, bool isGuest)
        {
            InitializeComponent();


            CurrentUser = currentUser;
            IsGuest = isGuest;

            lblUsername.Text = IsGuest ? "Гость" : $"{CurrentUser.FullName} ";


            using (var db = new VolunteersContext())
            {
                //if (CurrentUser?.IdRoleNavigation.RoleName != "Администратор")
                //{
                //    foreach (Button button in pnTop.Controls)
                //    {
                //        button.Visible = false;
                //    }
                //}
            }

            // Скрытый столбец ID
            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.Visible = false;
            colId.ReadOnly = true;

            // Столбец 1: Название мероприятия
            var colName = new DataGridViewTextBoxColumn();
            colName.Name = "colName";
            colName.HeaderText = "Название";
            colName.FillWeight = 25;
            colName.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colName.DefaultCellStyle.Font = new Font(dgvEvent.Font, FontStyle.Bold);

            // Столбец 2: Основная информация
            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.HeaderText = "Информация";
            colInfo.FillWeight = 55;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colInfo.DefaultCellStyle.Font = new Font(dgvEvent.Font, FontStyle.Regular);

            // Столбец 3: Статус
            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Статус";
            colStatus.FillWeight = 20;
            colStatus.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            colStatus.DefaultCellStyle.Font = new Font(dgvEvent.Font, FontStyle.Bold);

            dgvEvent.Columns.AddRange([colId, colName, colInfo, colStatus]);
            LoadEvents();
        }

        private void LoadEvents()
        {
            try
            {
                using (var db = new VolunteersContext())
                {
                    var events = db.Doings
                        .Include(i => i.IdCategoryNavigation)
                        .Include(i => i.IdPlaceNavigation)
                        .Include(i => i.IdUserNavigation)
                        .Include(i => i.IdStatusEventNavigation)
                        .ToList();

                    foreach (var doing in events)
                    {
                        int rowIndex = dgvEvent.Rows.Add();
                        var row = dgvEvent.Rows[rowIndex];

                        row.Cells["colId"].Value = doing.Id;
                        row.Cells["colName"].Value = doing.DoingName;
                        row.Cells["colInfo"].Value = FormatEventInfo(doing);
                        row.Cells["colStatus"].Value = doing.IdStatusEventNavigation.StatusName;

                        ApplyRowStyles(row, doing);
                    }
                    dgvEvent.ResumeLayout();
                    dgvEvent.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatEventInfo(Doing doing)
        {
            return $"Категория: {doing.IdCategoryNavigation.CategoryName}" + Environment.NewLine +
                   $"Дата: {doing.Date}" + Environment.NewLine +
                   $"Место: {doing.IdPlaceNavigation.PlaceName}" + Environment.NewLine +
                   $"Волонтёров: {doing.CountVolunteer}" + Environment.NewLine +
                   $"Координатор: {doing.IdUserNavigation.FullName}";
        }

        private void ApplyRowStyles(DataGridViewRow row, Doing doing)
        {
            string status = doing.IdStatusEventNavigation.StatusName;

            // Цвет фона строки
            if (status == "В процессе" || status == "Запланировано")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE5B4");
            }
            else if (status == "Завершено")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#90EE90");
            }
            else if (status == "Отменено")
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFB6C1");
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
