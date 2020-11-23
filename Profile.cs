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
        public Profile(string username)
        {
            InitializeComponent();
            this.username = username;
            getUser();
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
            SQLiteCommand cmd = conn.CreateCommand();
            if (tbPwd.Text.Equals(tbConPwd.Text) && !tbPwd.Text.Trim().Equals("") &&
                !tbConPwd.Text.Trim().Equals(""))
            {
                string pwd = BCrypt.Net.BCrypt.HashPassword(tbPwd.Text);
                cmd.CommandText = "UPDATE users SET password=@password";
                cmd.Parameters.AddWithValue("@password", pwd);
                int exe = cmd.ExecuteNonQuery();
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
}
