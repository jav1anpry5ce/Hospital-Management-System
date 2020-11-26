using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMSV2.Classes;
using System.Data.SQLite;

namespace HMSV2
{
    public partial class Profile : Form
    {
        private string username;
        private List<string> SecurityQuestion = new List<string>();
        public Profile(string username)
        {
            InitializeComponent();
            this.username = username;
            getUser();
            SecurityQuestion.Add("What was your childhood nickname?");
            SecurityQuestion.Add("What is the name of your favorite childhood friend?");
            SecurityQuestion.Add("What is your oldest sibling's middle name?");
            SecurityQuestion.Add("What school did you attend for sixth grade?");
            SecurityQuestion.Add("In what city or town was your first job?");
            SecurityQuestion.Add("What is the name of the company of your first job?");

            foreach (var que in SecurityQuestion)
            {
                cbSecQue1.Items.Add(que);
                cbSecQue2.Items.Add(que);
                cbSecQue3.Items.Add(que);
            }
            cbSecQue1.Text = "Please select an item";
            cbSecQue2.Text = "Please select an item";
            cbSecQue3.Text = "Please select an item";
        }
        private void getUser()
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT FirstName, LastName, username from users WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                labeluname.Text = data.GetString(2);
                labelFirstName.Text = data.GetString(0);
                labelLastName.Text = data.GetString(1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT password FROM users WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                string currentPassword = data.GetString(0);
                if (BCrypt.Net.BCrypt.Verify(tbCurrentPassword.Text, currentPassword) && tbPwd.Text.Equals(tbConPwd.Text)
                    && !tbPwd.Text.Trim().Equals("") && !tbConPwd.Text.Trim().Equals(""))
                {
                    SQLiteCommand cd = conn.CreateCommand();
                    string pwd = BCrypt.Net.BCrypt.HashPassword(tbPwd.Text);
                    cd.CommandText = "UPDATE users SET password=@password";
                    cd.Parameters.AddWithValue("@password", pwd);
                    int exe = cd.ExecuteNonQuery();
                    if (exe > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success");
                        tbPwd.Clear();
                        tbConPwd.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPwd.Clear();
                        tbConPwd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPwd.Clear();
                    tbConPwd.Clear();
                }
            }   
        }

        private void btUpdateSecQue_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            if (!cbSecQue1.Text.Trim().Equals("") && !cbSecQue2.Text.Trim().Equals("") &&
                !cbSecQue3.Text.Trim().Equals("") && !tbSecQue1.Text.Trim().Equals("") &&
                !tbSecQue2.Text.Trim().Equals("") && !tbSecQue3.Text.Trim().Equals(""))
            {
                cmd.CommandText = "UPDATE users SET SecQue1=@que1, SecQue2=@que2, SecQue3=@que3, SecQue1Ans=@ans1," +
                "SecQue2Ans=@ans2, SecQue3Ans=@ans3 WHERE username=@username";
                cmd.Parameters.AddWithValue("@que1", cbSecQue1.Text);
                cmd.Parameters.AddWithValue("@que2", cbSecQue2.Text);
                cmd.Parameters.AddWithValue("@que3", cbSecQue3.Text);
                cmd.Parameters.AddWithValue("@ans1", tbSecQue1.Text);
                cmd.Parameters.AddWithValue("@ans2", tbSecQue2.Text);
                cmd.Parameters.AddWithValue("@ans3", tbSecQue3.Text);
                cmd.Parameters.AddWithValue("@username", username);
                int exe = cmd.ExecuteNonQuery();
                if (exe > 0)
                {
                    MessageBox.Show("Security Questions Updated!", "Success");
                    tbSecQue1.Clear();
                    tbSecQue2.Clear();
                    tbSecQue3.Clear();
                }
                else
                    MessageBox.Show("Something went Wrong", "Error");
            }
            else
            {
                MessageBox.Show("Please select and answer security question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
