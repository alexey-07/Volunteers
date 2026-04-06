using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Volunteers_Project.Models;

namespace Volunteers_Project
{
    public partial class FormAdd : Form
    {
        private int _selectedId;
        public FormAdd(int id = -1)
        {
            InitializeComponent();
            _selectedId = id;

            LoadEventInfo();
        }

        private void LoadEventInfo()
        {
            using (var db = new VolunteersContext())
            {
                db.Categories.Load();
                db.Places.Load();
                db.Users.Load();
                db.StatusesEvents.Load();


                cbCategory.DataSource = db.Categories.Local.ToBindingList();
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "Id";

                cbPlace.DataSource = db.Places.Local.ToBindingList();
                cbPlace.DisplayMember = "PlaceName";
                cbPlace.ValueMember = "Id";

                cbVolonter.DataSource = db.Users.Local.ToBindingList();
                cbVolonter.DisplayMember = "FullName";
                cbVolonter.ValueMember = "Id";

                cbStatus.DataSource = db.StatusesEvents.Local.ToBindingList();
                cbStatus.DisplayMember = "StatusName";
                cbStatus.ValueMember = "Id";


                Doing doing;
                if (_selectedId != -1)
                {
                    doing = db.Doings.Find(_selectedId);

                    cbCategory.SelectedValue = doing.IdCategory;
                    cbPlace.SelectedValue = doing.IdPlace;
                    cbVolonter.SelectedValue = doing.IdUser;
                    cbStatus.SelectedValue = doing.IdStatusEvent;

                }
                else
                {
                    doing = new Doing();
                }

                txtName.Text = doing.DoingName;
                

            }
        }
    }
}
