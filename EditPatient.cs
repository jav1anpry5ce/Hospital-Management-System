using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SQLite;
using HMSV2.Classes;

namespace HMSV2
{
    public partial class EditPatient : Form
    {
        private string trn;
        public EditPatient(string trn)
        {
            InitializeComponent();
            this.trn = trn;
            cbAdmitted.Items.Add("True");
            cbAdmitted.Items.Add("False");
            cbSex.Items.Add("Male");
            cbSex.Items.Add("Female");
            cbSex.Items.Add("Other");
            populate(); 
        }
        private void populate()
        {
            this.trn = Tools.trnmodifer(this.trn);
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TRN, FirstName, LastName, DOB," +
                "SEX, StreetAddress, City, Zip, Country, Email," +
                "Contact, NextOfKin, NextOfKinContact," +
                "Admitted, Doctor from patients WHERE TRN = @TRN";
            cmd.Parameters.AddWithValue("@TRN", this.trn);
            try
            {
                data = cmd.ExecuteReader();
                if (!data.HasRows)
                {
                    MessageBox.Show("Could not find patient!", "Error");
                }
                else
                {
                    while (data.Read())
                    {
                        tbTrn.Text = data.GetString(0);
                        tbFirstName.Text = data.GetString(1);
                        tbLastName.Text = data.GetString(2);
                        dtpDOB.Value = Convert.ToDateTime(data.GetString(3));
                        cbSex.Text = data.GetString(4);
                        tbStreetAddress.Text = data.GetString(5);
                        tbCity.Text = data.GetString(6);
                        tbZip.Text = data.GetString(7);
                        tbCountry.Text = data.GetString(8);
                        tbEmail.Text = data.GetString(9);
                        tbContact.Text = data.GetString(10);
                        tbNOK.Text = data.GetString(11);
                        tbNOKContact.Text = data.GetString(12);
                        cbAdmitted.Text = data.GetString(13);
                        tbDoctor.Text = data.GetString(14);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong!", "Error");
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE patients SET FirstName=@fname, LastName=@lname, DOB=@dob," +
                "SEX=@sex, StreetAddress=@sadd, City=@city, Zip=@zip, Country=@country, Email=@email," +
                "Contact=@contact, NextOfKin=@nok, NextOfKinContact = @nokcontact," +
                "Admitted=@admitted, Doctor=@doctor WHERE TRN=@trn";
            cmd.Parameters.AddWithValue("@fname", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@lname", tbLastName.Text);
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@sex", cbSex.Text);
            cmd.Parameters.AddWithValue("@sadd", tbStreetAddress.Text);
            cmd.Parameters.AddWithValue("@city", tbCity.Text);
            cmd.Parameters.AddWithValue("@zip", tbZip.Text);
            cmd.Parameters.AddWithValue("@country", tbCountry.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.Parameters.AddWithValue("@contact", tbContact.Text);
            cmd.Parameters.AddWithValue("@nok", tbNOK.Text);
            cmd.Parameters.AddWithValue("@nokcontact", tbNOKContact.Text);
            cmd.Parameters.AddWithValue("@admitted", cbAdmitted.Text);
            cmd.Parameters.AddWithValue("@doctor", tbDoctor.Text);
            cmd.Parameters.AddWithValue("@trn", tbTrn.Text);
            int exe = cmd.ExecuteNonQuery();
            if (exe > 0)
            {
                MessageBox.Show("Patient information updated!", "Success");
                populate();
            }
                
            else
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
