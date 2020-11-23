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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
            dtpTime.Format = DateTimePickerFormat.Time;
            dgvAppointments.DataSource = getAppointments();
        }
        private void makeAppointment()
        {
            string trn = Tools.trnmodifer(tbTrn.Text);
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE patients SET AppointmentDate=@appointmentdate," +
                "AppointmentTime=@appointmenttime, Doctor=@doctor, HasAppointment='True' WHERE TRN=@trn";
            cmd.Parameters.AddWithValue("@appointmentdate", dtpAppointmentDate.Value.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@appointmenttime", dtpTime.Value.ToString("t"));
            cmd.Parameters.AddWithValue("@doctor", tbDoctor.Text);
            cmd.Parameters.AddWithValue("@trn", trn);
            int exe = cmd.ExecuteNonQuery();
            if (exe > 0)
            {
                MessageBox.Show("Appointment was successfully made!", "Success");
                tbTrn.Clear();
                tbDoctor.Clear();
                dgvAppointments.DataSource = getAppointments();
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTrn.Clear();
                tbDoctor.Clear();
                dgvAppointments.DataSource = getAppointments();
            }
        }
        private DataTable getAppointments()
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            DataTable dt = new DataTable();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, Contact," +
                "AppointmentDate, AppointmentTime, Doctor FROM patients WHERE HasAppointment='True'";
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                if (DateTime.Now > Convert.ToDateTime(data.GetString(4)))
                {
                    SQLiteCommand cd = conn.CreateCommand();
                    cd.CommandText = "Update patients SET HasAppointment='False' WHERE AppointmentDate < @date";
                    cd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy"));
                    cd.ExecuteNonQuery();
                }
            }
            data.Close();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, Contact," +
                "AppointmentDate, AppointmentTime, Doctor FROM patients WHERE HasAppointment='True'";
            data = cmd.ExecuteReader();
            dt.Load(data);
            return dt;
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            makeAppointment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            DataTable dt = new DataTable();
            SQLiteDataReader data;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, Contact," +
                "AppointmentDate, AppointmentTime, Doctor FROM patients WHERE AppointmentDate=@date";
            cmd.Parameters.AddWithValue("@date", dtpAppointments.Value.ToString("dd/MM/yyyy"));
            data = cmd.ExecuteReader();
            dt.Load(data);
            dgvAppointments.DataSource = dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvAppointments.DataSource = getAppointments();
        }
    }
}
