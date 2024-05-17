namespace Swift
{
    partial class applicant_notif
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
            this.applicant_lbl1 = new System.Windows.Forms.Label();
            this.Applicant_Datagrdvw1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_Datagrdvw1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicant_lbl1
            // 
            this.applicant_lbl1.AutoSize = true;
            this.applicant_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl1.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Location = new System.Drawing.Point(289, 23);
            this.applicant_lbl1.Name = "applicant_lbl1";
            this.applicant_lbl1.Size = new System.Drawing.Size(217, 32);
            this.applicant_lbl1.TabIndex = 1;
            this.applicant_lbl1.Text = "Notification Form";
            // 
            // Applicant_Datagrdvw1
            // 
            this.Applicant_Datagrdvw1.AllowUserToAddRows = false;
            this.Applicant_Datagrdvw1.AllowUserToDeleteRows = false;
            this.Applicant_Datagrdvw1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_Datagrdvw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Applicant_Datagrdvw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.Applicant_Datagrdvw1.Location = new System.Drawing.Point(164, 58);
            this.Applicant_Datagrdvw1.Name = "Applicant_Datagrdvw1";
            this.Applicant_Datagrdvw1.ReadOnly = true;
            this.Applicant_Datagrdvw1.Size = new System.Drawing.Size(459, 416);
            this.Applicant_Datagrdvw1.TabIndex = 2;
            this.Applicant_Datagrdvw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Job_Title";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Applicant Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Contact Information";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 114;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "CV";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 46;
            // 
            // applicant_notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 550);
            this.Controls.Add(this.Applicant_Datagrdvw1);
            this.Controls.Add(this.applicant_lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "applicant_notif";
            this.Text = "applicant_notif";
            this.Load += new System.EventHandler(this.applicant_notif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_Datagrdvw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicant_lbl1;
        private System.Windows.Forms.DataGridView Applicant_Datagrdvw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}