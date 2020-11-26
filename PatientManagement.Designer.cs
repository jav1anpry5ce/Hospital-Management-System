namespace HMSV2
{
    partial class PatientManagement
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelSrc = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnView);
            this.panelMain.Controls.Add(this.panelView);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.tbSearch);
            this.panelMain.Controls.Add(this.labelSrc);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1177, 702);
            this.panelMain.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(497, 61);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(93, 30);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridViewPatient);
            this.panelView.Location = new System.Drawing.Point(0, 102);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1177, 600);
            this.panelView.TabIndex = 5;
            // 
            // dataGridViewPatient
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewPatient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatient.RowTemplate.Height = 25;
            this.dataGridViewPatient.RowTemplate.ReadOnly = true;
            this.dataGridViewPatient.Size = new System.Drawing.Size(1153, 579);
            this.dataGridViewPatient.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 61);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(73, 64);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(295, 26);
            this.tbSearch.TabIndex = 2;
            // 
            // labelSrc
            // 
            this.labelSrc.AutoSize = true;
            this.labelSrc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSrc.Location = new System.Drawing.Point(6, 69);
            this.labelSrc.Name = "labelSrc";
            this.labelSrc.Size = new System.Drawing.Size(61, 21);
            this.labelSrc.TabIndex = 1;
            this.labelSrc.Text = "Search";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1177, 54);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(461, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(299, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Patient Management";
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 702);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientManagement";
            this.Text = "PatientManagement";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelSrc;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnView;
    }
}