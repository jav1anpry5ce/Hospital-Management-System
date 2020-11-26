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
    public partial class ForgetPassword : Form
    {
        Random rand = new Random();
        private int que;
        private string username;
        public ForgetPassword(string username)
        {
            InitializeComponent();
            this.que = rand.Next(1, 4);
            this.username = username;
            getSecQue();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            string command = string.Format("SELECT SecQue{0}Ans FROM users WHERE username='{1}'", que, username);
            cmd.CommandText = command;
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                if (data.GetString(0).Equals(tbAns.Text) && tbNewPwd.Text.Equals(tbConPwd.Text))
                {
                    try
                    {
                        SQLiteCommand cd = conn.CreateCommand();
                        cd.CommandText = "UPDATE users SET password=@pwd WHERE username=@username";
                        cd.Parameters.AddWithValue("@pwd", BCrypt.Net.BCrypt.HashPassword(tbNewPwd.Text));
                        cd.Parameters.AddWithValue("@username", username);
                        int exe = cd.ExecuteNonQuery();
                        if (exe > 0)
                        {
                            MessageBox.Show("Password updated!", "Success");
                            Form login = new frmLogin();
                            login.Show();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Form login = new frmLogin();
                            login.Show();
                            this.Dispose();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form login = new frmLogin();
                        login.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong security answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNewPwd.Clear();
                    tbConPwd.Clear();
                    tbAns.Clear();
                }
            }
        }
        private void getSecQue()
        {
            string command = String.Format("SELECT SecQue{0} FROM users WHERE username='{1}'", que, username);
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = command;
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                if (data.IsDBNull(0) || data.GetString(0).Equals(""))
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                    tbSecQue.Text = data.GetString(0);
            }
            conn.Close();
        }
        private void ForgetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new frmLogin();
            login.Show();
            this.Dispose();
        }
    }
}
