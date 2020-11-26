
namespace HMSV2
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.labelConPwd = new System.Windows.Forms.Label();
            this.tbConPwd = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labeluname = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.labelSecurityQuestion = new System.Windows.Forms.Label();
            this.cbSecQue1 = new System.Windows.Forms.ComboBox();
            this.cbSecQue2 = new System.Windows.Forms.ComboBox();
            this.labelSecQue2 = new System.Windows.Forms.Label();
            this.cbSecQue3 = new System.Windows.Forms.ComboBox();
            this.labelSec3 = new System.Windows.Forms.Label();
            this.tbSecQue1 = new System.Windows.Forms.TextBox();
            this.tbSecQue2 = new System.Windows.Forms.TextBox();
            this.tbSecQue3 = new System.Windows.Forms.TextBox();
            this.btUpdateSecQue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFName.Location = new System.Drawing.Point(211, 136);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(92, 21);
            this.labelFName.TabIndex = 1;
            this.labelFName.Text = "First Name";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPwd.Location = new System.Drawing.Point(22, 593);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(123, 21);
            this.labelPwd.TabIndex = 3;
            this.labelPwd.Text = "New Password";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(180, 588);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(412, 26);
            this.tbPwd.TabIndex = 9;
            // 
            // labelConPwd
            // 
            this.labelConPwd.AutoSize = true;
            this.labelConPwd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConPwd.Location = new System.Drawing.Point(21, 635);
            this.labelConPwd.Name = "labelConPwd";
            this.labelConPwd.Size = new System.Drawing.Size(151, 21);
            this.labelConPwd.TabIndex = 5;
            this.labelConPwd.Text = "Confirm Password";
            // 
            // tbConPwd
            // 
            this.tbConPwd.Location = new System.Drawing.Point(180, 633);
            this.tbConPwd.Name = "tbConPwd";
            this.tbConPwd.PasswordChar = '*';
            this.tbConPwd.Size = new System.Drawing.Size(412, 26);
            this.tbConPwd.TabIndex = 10;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLName.Location = new System.Drawing.Point(212, 181);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(90, 21);
            this.labelLName.TabIndex = 7;
            this.labelLName.Text = "Last Name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(212, 92);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 21);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(668, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 46);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labeluname
            // 
            this.labeluname.AutoSize = true;
            this.labeluname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeluname.Location = new System.Drawing.Point(319, 92);
            this.labeluname.Name = "labeluname";
            this.labeluname.Size = new System.Drawing.Size(53, 21);
            this.labeluname.TabIndex = 11;
            this.labeluname.Text = "label1";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(319, 138);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(53, 21);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "label1";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(319, 181);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 21);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "label1";
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPassword.Location = new System.Drawing.Point(22, 546);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(145, 21);
            this.labelCurrentPassword.TabIndex = 14;
            this.labelCurrentPassword.Text = "Current Password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(180, 546);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(412, 26);
            this.tbCurrentPassword.TabIndex = 8;
            // 
            // labelSecurityQuestion
            // 
            this.labelSecurityQuestion.AutoSize = true;
            this.labelSecurityQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecurityQuestion.Location = new System.Drawing.Point(21, 296);
            this.labelSecurityQuestion.Name = "labelSecurityQuestion";
            this.labelSecurityQuestion.Size = new System.Drawing.Size(157, 21);
            this.labelSecurityQuestion.TabIndex = 16;
            this.labelSecurityQuestion.Text = "Security Question 1";
            // 
            // cbSecQue1
            // 
            this.cbSecQue1.FormattingEnabled = true;
            this.cbSecQue1.Location = new System.Drawing.Point(180, 294);
            this.cbSecQue1.Name = "cbSecQue1";
            this.cbSecQue1.Size = new System.Drawing.Size(412, 27);
            this.cbSecQue1.TabIndex = 1;
            // 
            // cbSecQue2
            // 
            this.cbSecQue2.FormattingEnabled = true;
            this.cbSecQue2.Location = new System.Drawing.Point(180, 337);
            this.cbSecQue2.Name = "cbSecQue2";
            this.cbSecQue2.Size = new System.Drawing.Size(412, 27);
            this.cbSecQue2.TabIndex = 3;
            // 
            // labelSecQue2
            // 
            this.labelSecQue2.AutoSize = true;
            this.labelSecQue2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecQue2.Location = new System.Drawing.Point(21, 339);
            this.labelSecQue2.Name = "labelSecQue2";
            this.labelSecQue2.Size = new System.Drawing.Size(157, 21);
            this.labelSecQue2.TabIndex = 18;
            this.labelSecQue2.Text = "Security Question 2";
            // 
            // cbSecQue3
            // 
            this.cbSecQue3.FormattingEnabled = true;
            this.cbSecQue3.Location = new System.Drawing.Point(180, 382);
            this.cbSecQue3.Name = "cbSecQue3";
            this.cbSecQue3.Size = new System.Drawing.Size(412, 27);
            this.cbSecQue3.TabIndex = 5;
            // 
            // labelSec3
            // 
            this.labelSec3.AutoSize = true;
            this.labelSec3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSec3.Location = new System.Drawing.Point(21, 384);
            this.labelSec3.Name = "labelSec3";
            this.labelSec3.Size = new System.Drawing.Size(157, 21);
            this.labelSec3.TabIndex = 20;
            this.labelSec3.Text = "Security Question 3";
            // 
            // tbSecQue1
            // 
            this.tbSecQue1.Location = new System.Drawing.Point(630, 296);
            this.tbSecQue1.Name = "tbSecQue1";
            this.tbSecQue1.Size = new System.Drawing.Size(390, 26);
            this.tbSecQue1.TabIndex = 2;
            // 
            // tbSecQue2
            // 
            this.tbSecQue2.Location = new System.Drawing.Point(630, 339);
            this.tbSecQue2.Name = "tbSecQue2";
            this.tbSecQue2.Size = new System.Drawing.Size(390, 26);
            this.tbSecQue2.TabIndex = 4;
            // 
            // tbSecQue3
            // 
            this.tbSecQue3.Location = new System.Drawing.Point(630, 384);
            this.tbSecQue3.Name = "tbSecQue3";
            this.tbSecQue3.Size = new System.Drawing.Size(390, 26);
            this.tbSecQue3.TabIndex = 6;
            // 
            // btUpdateSecQue
            // 
            this.btUpdateSecQue.Location = new System.Drawing.Point(553, 449);
            this.btUpdateSecQue.Name = "btUpdateSecQue";
            this.btUpdateSecQue.Size = new System.Drawing.Size(115, 41);
            this.btUpdateSecQue.TabIndex = 7;
            this.btUpdateSecQue.Text = "Update";
            this.btUpdateSecQue.UseVisualStyleBackColor = true;
            this.btUpdateSecQue.Click += new System.EventHandler(this.btUpdateSecQue_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1177, 702);
            this.Controls.Add(this.btUpdateSecQue);
            this.Controls.Add(this.tbSecQue3);
            this.Controls.Add(this.tbSecQue2);
            this.Controls.Add(this.tbSecQue1);
            this.Controls.Add(this.cbSecQue3);
            this.Controls.Add(this.labelSec3);
            this.Controls.Add(this.cbSecQue2);
            this.Controls.Add(this.labelSecQue2);
            this.Controls.Add(this.cbSecQue1);
            this.Controls.Add(this.labelSecurityQuestion);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labeluname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.tbConPwd);
            this.Controls.Add(this.labelConPwd);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label labelConPwd;
        private System.Windows.Forms.TextBox tbConPwd;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labeluname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label labelSecurityQuestion;
        private System.Windows.Forms.ComboBox cbSecQue1;
        private System.Windows.Forms.ComboBox cbSecQue2;
        private System.Windows.Forms.Label labelSecQue2;
        private System.Windows.Forms.ComboBox cbSecQue3;
        private System.Windows.Forms.Label labelSec3;
        private System.Windows.Forms.TextBox tbSecQue1;
        private System.Windows.Forms.TextBox tbSecQue2;
        private System.Windows.Forms.TextBox tbSecQue3;
        private System.Windows.Forms.Button btUpdateSecQue;
    }
}