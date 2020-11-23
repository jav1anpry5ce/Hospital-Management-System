
namespace HMSV2
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.labelLname = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.labelConPwd = new System.Windows.Forms.Label();
            this.tbConPwd = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelSuperUser = new System.Windows.Forms.Label();
            this.cbSuperUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(234, 304);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(108, 27);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(426, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 135);
            this.panel1.TabIndex = 5;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(430, 305);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(298, 26);
            this.tbUsername.TabIndex = 3;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFName.Location = new System.Drawing.Point(234, 200);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(118, 27);
            this.labelFName.TabIndex = 7;
            this.labelFName.Text = "First Name";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(430, 203);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(298, 26);
            this.tbFName.TabIndex = 1;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLname.Location = new System.Drawing.Point(234, 253);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(117, 27);
            this.labelLname.TabIndex = 9;
            this.labelLname.Text = "Last Name";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(430, 256);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(298, 26);
            this.tbLName.TabIndex = 2;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPwd.Location = new System.Drawing.Point(234, 354);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(104, 27);
            this.labelPwd.TabIndex = 11;
            this.labelPwd.Text = "Password";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(430, 354);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(298, 26);
            this.tbPwd.TabIndex = 4;
            // 
            // labelConPwd
            // 
            this.labelConPwd.AutoSize = true;
            this.labelConPwd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConPwd.Location = new System.Drawing.Point(234, 404);
            this.labelConPwd.Name = "labelConPwd";
            this.labelConPwd.Size = new System.Drawing.Size(190, 27);
            this.labelConPwd.TabIndex = 13;
            this.labelConPwd.Text = "Confirm Password";
            // 
            // tbConPwd
            // 
            this.tbConPwd.Location = new System.Drawing.Point(430, 404);
            this.tbConPwd.Name = "tbConPwd";
            this.tbConPwd.PasswordChar = '*';
            this.tbConPwd.Size = new System.Drawing.Size(298, 26);
            this.tbConPwd.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(517, 505);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 48);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelSuperUser
            // 
            this.labelSuperUser.AutoSize = true;
            this.labelSuperUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuperUser.Location = new System.Drawing.Point(235, 444);
            this.labelSuperUser.Name = "labelSuperUser";
            this.labelSuperUser.Size = new System.Drawing.Size(117, 27);
            this.labelSuperUser.TabIndex = 16;
            this.labelSuperUser.Text = "Super User";
            // 
            // cbSuperUser
            // 
            this.cbSuperUser.FormattingEnabled = true;
            this.cbSuperUser.Location = new System.Drawing.Point(430, 447);
            this.cbSuperUser.Name = "cbSuperUser";
            this.cbSuperUser.Size = new System.Drawing.Size(298, 27);
            this.cbSuperUser.TabIndex = 6;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1177, 702);
            this.Controls.Add(this.cbSuperUser);
            this.Controls.Add(this.labelSuperUser);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbConPwd);
            this.Controls.Add(this.labelConPwd);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label labelConPwd;
        private System.Windows.Forms.TextBox tbConPwd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelSuperUser;
        private System.Windows.Forms.ComboBox cbSuperUser;
    }
}