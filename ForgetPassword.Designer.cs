
namespace HMSV2
{
    partial class ForgetPassword
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
            this.labelSecQue = new System.Windows.Forms.Label();
            this.tbSecQue = new System.Windows.Forms.TextBox();
            this.labelSecQueAns = new System.Windows.Forms.Label();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.labelNewPwd = new System.Windows.Forms.Label();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.labelConPwd = new System.Windows.Forms.Label();
            this.tbConPwd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelSecQue
            // 
            this.labelSecQue.AutoSize = true;
            this.labelSecQue.Location = new System.Drawing.Point(12, 57);
            this.labelSecQue.Name = "labelSecQue";
            this.labelSecQue.Size = new System.Drawing.Size(143, 21);
            this.labelSecQue.TabIndex = 0;
            this.labelSecQue.Text = "Security Question";
            // 
            // tbSecQue
            // 
            this.tbSecQue.Location = new System.Drawing.Point(169, 57);
            this.tbSecQue.Name = "tbSecQue";
            this.tbSecQue.ReadOnly = true;
            this.tbSecQue.Size = new System.Drawing.Size(412, 29);
            this.tbSecQue.TabIndex = 1;
            // 
            // labelSecQueAns
            // 
            this.labelSecQueAns.AutoSize = true;
            this.labelSecQueAns.Location = new System.Drawing.Point(12, 111);
            this.labelSecQueAns.Name = "labelSecQueAns";
            this.labelSecQueAns.Size = new System.Drawing.Size(67, 21);
            this.labelSecQueAns.TabIndex = 2;
            this.labelSecQueAns.Text = "Answer";
            // 
            // tbAns
            // 
            this.tbAns.Location = new System.Drawing.Point(169, 108);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(412, 29);
            this.tbAns.TabIndex = 3;
            // 
            // labelNewPwd
            // 
            this.labelNewPwd.AutoSize = true;
            this.labelNewPwd.Location = new System.Drawing.Point(12, 166);
            this.labelNewPwd.Name = "labelNewPwd";
            this.labelNewPwd.Size = new System.Drawing.Size(123, 21);
            this.labelNewPwd.TabIndex = 4;
            this.labelNewPwd.Text = "New Password";
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(169, 163);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '*';
            this.tbNewPwd.Size = new System.Drawing.Size(412, 29);
            this.tbNewPwd.TabIndex = 5;
            // 
            // labelConPwd
            // 
            this.labelConPwd.AutoSize = true;
            this.labelConPwd.Location = new System.Drawing.Point(12, 223);
            this.labelConPwd.Name = "labelConPwd";
            this.labelConPwd.Size = new System.Drawing.Size(151, 21);
            this.labelConPwd.TabIndex = 6;
            this.labelConPwd.Text = "Confirm Password";
            // 
            // tbConPwd
            // 
            this.tbConPwd.Location = new System.Drawing.Point(169, 220);
            this.tbConPwd.Name = "tbConPwd";
            this.tbConPwd.PasswordChar = '*';
            this.tbConPwd.Size = new System.Drawing.Size(412, 29);
            this.tbConPwd.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 291);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 52);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Change Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.Location = new System.Drawing.Point(12, 307);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(128, 21);
            this.linkLabelBack.TabIndex = 8;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "Return to Login";
            this.linkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 390);
            this.Controls.Add(this.linkLabelBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbConPwd);
            this.Controls.Add(this.labelConPwd);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.labelNewPwd);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.labelSecQueAns);
            this.Controls.Add(this.tbSecQue);
            this.Controls.Add(this.labelSecQue);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(632, 429);
            this.MinimumSize = new System.Drawing.Size(632, 429);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgetPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSecQue;
        private System.Windows.Forms.TextBox tbSecQue;
        private System.Windows.Forms.Label labelSecQueAns;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label labelNewPwd;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.Label labelConPwd;
        private System.Windows.Forms.TextBox tbConPwd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel linkLabelBack;
    }
}