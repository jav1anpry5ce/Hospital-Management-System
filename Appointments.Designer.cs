
namespace HMSV2
{
    partial class Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTItle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMakeAppointment = new System.Windows.Forms.Panel();
            this.btnMake = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.tbDoctor = new System.Windows.Forms.TextBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.tbTrn = new System.Windows.Forms.TextBox();
            this.labelTrn = new System.Windows.Forms.Label();
            this.panelViewAppointments = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpAppointments = new System.Windows.Forms.DateTimePicker();
            this.labelSrc = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.panelTItle.SuspendLayout();
            this.panelMakeAppointment.SuspendLayout();
            this.panelViewAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTItle
            // 
            this.panelTItle.AutoSize = true;
            this.panelTItle.Controls.Add(this.labelTitle);
            this.panelTItle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTItle.Location = new System.Drawing.Point(0, 0);
            this.panelTItle.Name = "panelTItle";
            this.panelTItle.Size = new System.Drawing.Size(1177, 47);
            this.panelTItle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(483, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(230, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Appointments";
            // 
            // panelMakeAppointment
            // 
            this.panelMakeAppointment.Controls.Add(this.btnMake);
            this.panelMakeAppointment.Controls.Add(this.dtpTime);
            this.panelMakeAppointment.Controls.Add(this.labelTime);
            this.panelMakeAppointment.Controls.Add(this.dtpAppointmentDate);
            this.panelMakeAppointment.Controls.Add(this.labelDate);
            this.panelMakeAppointment.Controls.Add(this.tbDoctor);
            this.panelMakeAppointment.Controls.Add(this.labelDoctor);
            this.panelMakeAppointment.Controls.Add(this.tbTrn);
            this.panelMakeAppointment.Controls.Add(this.labelTrn);
            this.panelMakeAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMakeAppointment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMakeAppointment.Location = new System.Drawing.Point(0, 47);
            this.panelMakeAppointment.Name = "panelMakeAppointment";
            this.panelMakeAppointment.Size = new System.Drawing.Size(1177, 159);
            this.panelMakeAppointment.TabIndex = 1;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(466, 101);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(191, 36);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "Make Appointment";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(752, 55);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(323, 26);
            this.dtpTime.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(696, 60);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(47, 21);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(752, 18);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(323, 26);
            this.dtpAppointmentDate.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(699, 21);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(44, 21);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            // 
            // tbDoctor
            // 
            this.tbDoctor.Location = new System.Drawing.Point(79, 54);
            this.tbDoctor.Name = "tbDoctor";
            this.tbDoctor.Size = new System.Drawing.Size(320, 26);
            this.tbDoctor.TabIndex = 3;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDoctor.Location = new System.Drawing.Point(12, 58);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(63, 21);
            this.labelDoctor.TabIndex = 2;
            this.labelDoctor.Text = "Doctor";
            // 
            // tbTrn
            // 
            this.tbTrn.Location = new System.Drawing.Point(79, 16);
            this.tbTrn.Name = "tbTrn";
            this.tbTrn.Size = new System.Drawing.Size(320, 26);
            this.tbTrn.TabIndex = 1;
            // 
            // labelTrn
            // 
            this.labelTrn.AutoSize = true;
            this.labelTrn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrn.Location = new System.Drawing.Point(12, 18);
            this.labelTrn.Name = "labelTrn";
            this.labelTrn.Size = new System.Drawing.Size(48, 21);
            this.labelTrn.TabIndex = 0;
            this.labelTrn.Text = "TRN";
            // 
            // panelViewAppointments
            // 
            this.panelViewAppointments.Controls.Add(this.btnView);
            this.panelViewAppointments.Controls.Add(this.btnSearch);
            this.panelViewAppointments.Controls.Add(this.dtpAppointments);
            this.panelViewAppointments.Controls.Add(this.labelSrc);
            this.panelViewAppointments.Controls.Add(this.dgvAppointments);
            this.panelViewAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewAppointments.Location = new System.Drawing.Point(0, 206);
            this.panelViewAppointments.Name = "panelViewAppointments";
            this.panelViewAppointments.Size = new System.Drawing.Size(1177, 498);
            this.panelViewAppointments.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(549, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 29);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(429, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpAppointments
            // 
            this.dtpAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAppointments.Location = new System.Drawing.Point(79, 6);
            this.dtpAppointments.Name = "dtpAppointments";
            this.dtpAppointments.Size = new System.Drawing.Size(287, 28);
            this.dtpAppointments.TabIndex = 2;
            // 
            // labelSrc
            // 
            this.labelSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSrc.AutoSize = true;
            this.labelSrc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSrc.Location = new System.Drawing.Point(12, 11);
            this.labelSrc.Name = "labelSrc";
            this.labelSrc.Size = new System.Drawing.Size(61, 21);
            this.labelSrc.TabIndex = 1;
            this.labelSrc.Text = "Search";
            // 
            // dgvAppointments
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 35);
            this.dgvAppointments.Name = "dgvAppointments";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.RowTemplate.Height = 25;
            this.dgvAppointments.RowTemplate.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(1153, 447);
            this.dgvAppointments.TabIndex = 0;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 702);
            this.Controls.Add(this.panelViewAppointments);
            this.Controls.Add(this.panelMakeAppointment);
            this.Controls.Add(this.panelTItle);
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.panelTItle.ResumeLayout(false);
            this.panelTItle.PerformLayout();
            this.panelMakeAppointment.ResumeLayout(false);
            this.panelMakeAppointment.PerformLayout();
            this.panelViewAppointments.ResumeLayout(false);
            this.panelViewAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTItle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMakeAppointment;
        private System.Windows.Forms.Panel panelViewAppointments;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpAppointments;
        private System.Windows.Forms.Label labelSrc;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TextBox tbTrn;
        private System.Windows.Forms.Label labelTrn;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tbDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Button btnView;
    }
}