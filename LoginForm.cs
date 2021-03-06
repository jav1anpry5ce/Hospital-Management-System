﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using HMSV2.Classes;

namespace HMSV2
{
    public partial class frmLogin : Form
    {
        private string isSuperUser;
        private string username;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loggedIn = LoggedIn();

            if (loggedIn)
            {
                Form mainForm = new MainFrom(isSuperUser, username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check username and or password!", "login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassword.Text = "";
            }
        }
        private bool LoggedIn()
        {
            SQLiteConnection conn = DbConnection.CreateConnection();
            bool loggedIn = false;
            username = txbUsername.Text;
            string password = txbPassword.Text;

            SQLiteDataReader data;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT password, IsSuperUser FROM users WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                string pwd = data.GetString(0);
                isSuperUser = data.GetString(1);
                if (BCrypt.Net.BCrypt.Verify(password, pwd))
                    loggedIn = true;
            }
            data.Close();
            if (loggedIn)
            {
                DateTime now = DateTime.Now;
                cmd.CommandText = "UPDATE users SET lastLogin=@login WHERE username=@username";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@login", now);
                cmd.ExecuteNonQuery();
            }
            return loggedIn;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void linkLabelForgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = txbUsername.Text;
            SQLiteConnection conn = DbConnection.CreateConnection();
            SQLiteDataReader data;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM users WHERE username=@username";
            cmd.Parameters.AddWithValue("@username", username);
            data = cmd.ExecuteReader();
            if (!username.Trim().Equals("") && data.Read())
            {
                Form forgotPwd = new ForgetPassword(username);
                forgotPwd.Show();
                this.Hide();
                data.Close();
                conn.Close();
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUsername.Clear();
            }
        }
    }
}
