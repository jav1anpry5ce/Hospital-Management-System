namespace HMSV2
{
    partial class MainFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelHighlight = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdPat = new System.Windows.Forms.Button();
            this.btnMkApt = new System.Windows.Forms.Button();
            this.btnRegPat = new System.Windows.Forms.Button();
            this.btnPatMgt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.Controls.Add(this.panelHighlight);
            this.panelSide.Controls.Add(this.btnProfile);
            this.panelSide.Controls.Add(this.btnAddEmployee);
            this.panelSide.Controls.Add(this.btnLogout);
            this.panelSide.Controls.Add(this.btnAdPat);
            this.panelSide.Controls.Add(this.btnMkApt);
            this.panelSide.Controls.Add(this.btnRegPat);
            this.panelSide.Controls.Add(this.btnPatMgt);
            this.panelSide.Controls.Add(this.panel2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(198, 702);
            this.panelSide.TabIndex = 0;
            // 
            // panelHighlight
            // 
            this.panelHighlight.BackColor = System.Drawing.Color.LightBlue;
            this.panelHighlight.Location = new System.Drawing.Point(0, 159);
            this.panelHighlight.Name = "panelHighlight";
            this.panelHighlight.Size = new System.Drawing.Size(10, 23);
            this.panelHighlight.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnProfile.Location = new System.Drawing.Point(0, 646);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(198, 29);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = " Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 619);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(198, 30);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = " Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Visible = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 672);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(198, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdPat
            // 
            this.btnAdPat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdPat.FlatAppearance.BorderSize = 0;
            this.btnAdPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdPat.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnAdPat.Location = new System.Drawing.Point(0, 182);
            this.btnAdPat.Name = "btnAdPat";
            this.btnAdPat.Size = new System.Drawing.Size(198, 30);
            this.btnAdPat.TabIndex = 4;
            this.btnAdPat.Text = " Admit Patient";
            this.btnAdPat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdPat.UseVisualStyleBackColor = true;
            this.btnAdPat.Click += new System.EventHandler(this.btnAdPat_Click);
            // 
            // btnMkApt
            // 
            this.btnMkApt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMkApt.FlatAppearance.BorderSize = 0;
            this.btnMkApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMkApt.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnMkApt.Location = new System.Drawing.Point(0, 152);
            this.btnMkApt.Name = "btnMkApt";
            this.btnMkApt.Size = new System.Drawing.Size(198, 30);
            this.btnMkApt.TabIndex = 3;
            this.btnMkApt.Text = " Appointments";
            this.btnMkApt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMkApt.UseVisualStyleBackColor = true;
            this.btnMkApt.Click += new System.EventHandler(this.btnMkApt_Click);
            // 
            // btnRegPat
            // 
            this.btnRegPat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegPat.FlatAppearance.BorderSize = 0;
            this.btnRegPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegPat.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnRegPat.Location = new System.Drawing.Point(0, 122);
            this.btnRegPat.Name = "btnRegPat";
            this.btnRegPat.Size = new System.Drawing.Size(198, 30);
            this.btnRegPat.TabIndex = 2;
            this.btnRegPat.Text = " Register Patient";
            this.btnRegPat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegPat.UseVisualStyleBackColor = true;
            this.btnRegPat.Click += new System.EventHandler(this.btnRegPat_Click);
            // 
            // btnPatMgt
            // 
            this.btnPatMgt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatMgt.FlatAppearance.BorderSize = 0;
            this.btnPatMgt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatMgt.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnPatMgt.Location = new System.Drawing.Point(0, 92);
            this.btnPatMgt.Name = "btnPatMgt";
            this.btnPatMgt.Size = new System.Drawing.Size(198, 30);
            this.btnPatMgt.TabIndex = 1;
            this.btnPatMgt.Text = " Patient Management";
            this.btnPatMgt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatMgt.UseVisualStyleBackColor = true;
            this.btnPatMgt.Click += new System.EventHandler(this.btnPatMgt_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 92);
            this.panel2.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(198, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1170, 702);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1368, 702);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1384, 741);
            this.MinimumSize = new System.Drawing.Size(1384, 741);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrom_FormClosing);
            this.panelSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdPat;
        private System.Windows.Forms.Button btnMkApt;
        private System.Windows.Forms.Button btnRegPat;
        private System.Windows.Forms.Button btnPatMgt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelHighlight;
    }
}