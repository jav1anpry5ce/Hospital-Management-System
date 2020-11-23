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
    public partial class RegisterPatient : Form
    {
        public RegisterPatient()
        {
            InitializeComponent();
            cbSex.Items.Add("Male");
            cbSex.Items.Add("Female");
            cbSex.Items.Add("Other");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            string trn = Tools.trnmodifer(tbTrn.Text);
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string dob = dtpDOB.Value.ToString("dd/MM/yyyy");
            string sex = cbSex.Text;
            string streetAddress = tbStreetAddress.Text;
            string city = tbCity.Text;
            string zip = tbZip.Text;
            string country = tbCountry.Text;
            string email = tbEmail.Text;
            string contact = tbContact.Text;
            string nextOfKin = tbNOK.Text;
            string nextOfKinContact = tbNOKContact.Text;
            if (!trn.Trim().Equals("") && !firstname.Trim().Equals("") && !lastname.Trim().Equals("") && !dob.Trim().Equals("")
                    && !sex.Trim().Equals("") && !streetAddress.Trim().Equals("") && !city.Trim().Equals("") && !zip.Trim().Equals("")
                    && !country.Trim().Equals("") && !email.Trim().Equals("") && !contact.Trim().Equals("") && !nextOfKin.Trim().Equals("")
                    && !nextOfKinContact.Trim().Equals(""))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO patients(TRN, FirstName, LastName, DOB, SEX," +
                    "StreetAddress, City, Zip, Country, Email, Contact, NextOfKin, NextOfKinContact," +
                    "AppointmentDate, AppointmentTime, Admitted, Doctor, RoomNum) VALUES(@trn, @firstname," +
                    "@lastname, @dob, @sex, @streetaddress, @city, @zip, @country, @email, @contact, @nextofkin," +
                    "@nextofkincontact, 'N/A', 'N/A', 'False', 'N/A', 'N/A')";
                cmd.Parameters.AddWithValue("@trn", trn);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@streetaddress", streetAddress);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@zip", zip);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@nextofkin", nextOfKin);
                cmd.Parameters.AddWithValue("@nextofkincontact", nextOfKinContact);
                int exe = cmd.ExecuteNonQuery();
                if (exe > 0)
                {
                    tbTrn.Clear();
                    tbFirstName.Clear();
                    tbLastName.Clear();
                    tbStreetAddress.Clear();
                    tbCity.Clear();
                    tbZip.Clear();
                    tbCountry.Clear();
                    tbEmail.Clear();
                    tbContact.Clear();
                    tbNOK.Clear();
                    tbNOKContact.Clear();
                    MessageBox.Show("Patient Added succesfully!", "Success");
                }
                else
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All feilds must have a value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
