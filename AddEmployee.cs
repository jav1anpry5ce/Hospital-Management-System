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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            cbSuperUser.Items.Add("True");
            cbSuperUser.Items.Add("False");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteCommand cmd = conn.CreateCommand();
            if (!tbFName.Text.Trim().Equals("") && !tbFName.Text.Trim().Equals("") &&
                !tbUsername.Text.Trim().Equals("") && !tbPwd.Text.Trim().Equals("") &&
                !tbConPwd.Text.Trim().Equals("") && !cbSuperUser.Text.Equals(""))
            {
                if (tbPwd.Text.Equals(tbConPwd.Text))
                {
                    string pwd = BCrypt.Net.BCrypt.HashPassword(tbPwd.Text);
                    cmd.CommandText = "INSERT INTO users(username, FirstName, LastName," +
                    "password, IsSuperUser, lastLogin) VALUES (@username, @firstname, @lastname," +
                    "@password, @super, @lastLogin)";
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@firstname", tbFName.Text);
                    cmd.Parameters.AddWithValue("@lastname", tbLName.Text);
                    cmd.Parameters.AddWithValue("@password", pwd);
                    cmd.Parameters.AddWithValue("@super", cbSuperUser.Text);
                    cmd.Parameters.AddWithValue("@lastLogin", DateTime.Now);
                    int exe = cmd.ExecuteNonQuery();
                    if (exe > 0)
                    {
                        MessageBox.Show("Employee Add Successfully!", "Success");
                        tbFName.Clear();
                        tbLName.Clear();
                        tbUsername.Clear();
                        tbPwd.Clear();
                        tbConPwd.Clear();
                    }
                    else
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Passwords must match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPwd.Clear();
                    tbConPwd.Clear();
                }
            }
            else
                MessageBox.Show("All feilds must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
