
namespace HMSV2
{
    partial class AdmitPatient
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelAdmitPatient = new System.Windows.Forms.Panel();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.tbTrn2 = new System.Windows.Forms.TextBox();
            this.labelTrn2 = new System.Windows.Forms.Label();
            this.panelViewAdmitted = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTrn = new System.Windows.Forms.TextBox();
            this.labelTrn = new System.Windows.Forms.Label();
            this.dgvAdmitted = new System.Windows.Forms.DataGridView();
            this.panelTitle.SuspendLayout();
            this.panelAdmitPatient.SuspendLayout();
            this.panelViewAdmitted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmitted)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1177, 48);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(445, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(270, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Patient\'s Admittance";
            // 
            // panelAdmitPatient
            // 
            this.panelAdmitPatient.Controls.Add(this.btnAdmit);
            this.panelAdmitPatient.Controls.Add(this.tbRoom);
            this.panelAdmitPatient.Controls.Add(this.labelRoom);
            this.panelAdmitPatient.Controls.Add(this.tbTrn2);
            this.panelAdmitPatient.Controls.Add(this.labelTrn2);
            this.panelAdmitPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmitPatient.Location = new System.Drawing.Point(0, 48);
            this.panelAdmitPatient.Name = "panelAdmitPatient";
            this.panelAdmitPatient.Size = new System.Drawing.Size(1177, 152);
            this.panelAdmitPatient.TabIndex = 1;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(483, 82);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(127, 46);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit Patient";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(854, 27);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(264, 26);
            this.tbRoom.TabIndex = 3;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoom.Location = new System.Drawing.Point(726, 30);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(122, 21);
            this.labelRoom.TabIndex = 2;
            this.labelRoom.Text = "Room Number";
            // 
            // tbTrn2
            // 
            this.tbTrn2.Location = new System.Drawing.Point(58, 25);
            this.tbTrn2.Name = "tbTrn2";
            this.tbTrn2.Size = new System.Drawing.Size(276, 26);
            this.tbTrn2.TabIndex = 1;
            // 
            // labelTrn2
            // 
            this.labelTrn2.AutoSize = true;
            this.labelTrn2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrn2.Location = new System.Drawing.Point(4, 27);
            this.labelTrn2.Name = "labelTrn2";
            this.labelTrn2.Size = new System.Drawing.Size(48, 21);
            this.labelTrn2.TabIndex = 0;
            this.labelTrn2.Text = "TRN";
            // 
            // panelViewAdmitted
            // 
            this.panelViewAdmitted.Controls.Add(this.btnView);
            this.panelViewAdmitted.Controls.Add(this.btnSearch);
            this.panelViewAdmitted.Controls.Add(this.tbTrn);
            this.panelViewAdmitted.Controls.Add(this.labelTrn);
            this.panelViewAdmitted.Controls.Add(this.dgvAdmitted);
            this.panelViewAdmitted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewAdmitted.Location = new System.Drawing.Point(0, 200);
            this.panelViewAdmitted.Name = "panelViewAdmitted";
            this.panelViewAdmitted.Size = new System.Drawing.Size(1177, 502);
            this.panelViewAdmitted.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(483, 14);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 31);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(368, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTrn
            // 
            this.tbTrn.Location = new System.Drawing.Point(58, 11);
            this.tbTrn.Name = "tbTrn";
            this.tbTrn.Size = new System.Drawing.Size(276, 26);
            this.tbTrn.TabIndex = 2;
            // 
            // labelTrn
            // 
            this.labelTrn.AutoSize = true;
            this.labelTrn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrn.Location = new System.Drawing.Point(4, 14);
            this.labelTrn.Name = "labelTrn";
            this.labelTrn.Size = new System.Drawing.Size(48, 21);
            this.labelTrn.TabIndex = 1;
            this.labelTrn.Text = "TRN";
            // 
            // dgvAdmitted
            // 
            this.dgvAdmitted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmitted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAdmitted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmitted.Location = new System.Drawing.Point(12, 61);
            this.dgvAdmitted.Name = "dgvAdmitted";
            this.dgvAdmitted.RowTemplate.Height = 25;
            this.dgvAdmitted.RowTemplate.ReadOnly = true;
            this.dgvAdmitted.Size = new System.Drawing.Size(1153, 429);
            this.dgvAdmitted.TabIndex = 0;
            // 
            // AdmitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 702);
            this.Controls.Add(this.panelViewAdmitted);
            this.Controls.Add(this.panelAdmitPatient);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdmitPatient";
            this.Text = "AdmitPatient";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelAdmitPatient.ResumeLayout(false);
            this.panelAdmitPatient.PerformLayout();
            this.panelViewAdmitted.ResumeLayout(false);
            this.panelViewAdmitted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmitted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelAdmitPatient;
        private System.Windows.Forms.Panel panelViewAdmitted;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.TextBox tbTrn2;
        private System.Windows.Forms.Label labelTrn2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbTrn;
        private System.Windows.Forms.Label labelTrn;
        private System.Windows.Forms.DataGridView dgvAdmitted;
    }
}