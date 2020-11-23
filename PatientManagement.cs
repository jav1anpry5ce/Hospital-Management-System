using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using HMSV2.Classes;

namespace HMSV2
{
    public partial class PatientManagement : Form
    {
        public PatientManagement()
        {
            InitializeComponent();
            dataGridViewPatient.DataSource = populate();
        }
        private DataTable populate()
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd;
            DataTable dt = new DataTable();
            SQLiteDataReader data;
            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT TRN, FirstName, LastName, DOB," +
                "SEX, StreetAddress, City, Zip, Country, Email," +
                "Contact, NextOfKin, NextOfKinContact, AppointmentDate," +
                "AppointmentTime, Doctor from patients";
            data = cmd.ExecuteReader();
            dt.Load(data);
            return dt;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            dataGridViewPatient.Hide();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelView.Controls.Add(childForm);
            panelView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string trn = tbSearch.Text;
            if (!trn.Trim().Equals(""))
                openChildForm(new EditPatient(trn));
            else
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                    dataGridViewPatient.Show();
                    dataGridViewPatient.DataSource = populate();
                }
            }  
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                tbSearch.Clear();
                activeForm.Close();
                dataGridViewPatient.Show();
                dataGridViewPatient.DataSource = populate();
            }
        }
    }
}
