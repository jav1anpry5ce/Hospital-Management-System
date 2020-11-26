using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HMSV2
{
    public partial class MainFrom : Form
    {
        private string isSuperUser;
        private string username;
        private Form activeForm = null;
        public MainFrom(string isSuperUser, string username)
        {
            InitializeComponent();
            openChildForm(new Appointments());
            this.isSuperUser = isSuperUser;
            this.username = username;
            panelHighlight.Top = btnMkApt.Top;
            panelHighlight.Height = btnMkApt.Height;
            if (isSuperUser.Equals("True"))
            {
                btnAddEmployee.Show();
            }
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnPatMgt_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientManagement());
            panelHighlight.Top = btnPatMgt.Top;
            panelHighlight.Height = btnPatMgt.Height;
        }

        private void btnRegPat_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterPatient());
            panelHighlight.Top = btnRegPat.Top;
            panelHighlight.Height = btnRegPat.Height;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response.Equals(DialogResult.Yes))
            {
                Form loginForm = new frmLogin();
                loginForm.Show();
                this.Dispose();
            }
        }

        private void btnMkApt_Click(object sender, EventArgs e)
        {
            openChildForm(new Appointments());
            panelHighlight.Top = btnMkApt.Top;
            panelHighlight.Height = btnMkApt.Height;
        }

        private void btnAdPat_Click(object sender, EventArgs e)
        {
            openChildForm(new AdmitPatient());
            panelHighlight.Top = btnAdPat.Top;
            panelHighlight.Height = btnAdPat.Height;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new AddEmployee());
            panelHighlight.Top = btnAddEmployee.Top;
            panelHighlight.Height = btnAddEmployee.Height;
        }

        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response.Equals(DialogResult.Yes))
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new Profile(username));
            panelHighlight.Top = btnProfile.Top;
            panelHighlight.Height = btnProfile.Height;
        }
    }
}
