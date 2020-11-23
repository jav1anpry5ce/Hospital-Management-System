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
    public partial class AdmitPatient : Form
    {
        public AdmitPatient()
        {
            InitializeComponent();
            dgvAdmitted.DataSource = getAdmitted();
        }
        private DataTable getAdmitted()
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            DataTable dt = new DataTable();
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, NextOfKin, RoomNum, Admitted FROM patients WHERE Admitted='True'";
            data = cmd.ExecuteReader();
            dt.Load(data);
            return dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvAdmitted.DataSource = getAdmitted();
            tbTrn.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string trn = Tools.trnmodifer(tbTrn.Text);
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            DataTable dt = new DataTable();
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, NextOfKin, RoomNum, Admitted FROM patients WHERE Admitted='True' and TRN=@trn";
            cmd.Parameters.AddWithValue("@trn", trn);
            data = cmd.ExecuteReader();
            dt.Load(data);
            dgvAdmitted.DataSource = dt;
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            string trn = Tools.trnmodifer(tbTrn2.Text);
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE patients SET Admitted='True', RoomNum=@num WHERE TRN=@trn";
            cmd.Parameters.AddWithValue("@trn", trn);
            cmd.Parameters.AddWithValue("@num", tbRoom.Text);
            int exe = cmd.ExecuteNonQuery();
            if (exe > 0)
            {
                dgvAdmitted.DataSource = getAdmitted();
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbTrn2.Clear();
            tbRoom.Clear();
        }
    }
}
