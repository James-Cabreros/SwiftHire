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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.applicant_lbl1 = new System.Windows.Forms.Label();
            this.applicant_datagrdvw1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.applicant_txtbx1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.applicant_datagrdvw1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicant_lbl1
            // 
            this.applicant_lbl1.AutoSize = true;
            this.applicant_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl1.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Location = new System.Drawing.Point(28, 23);
            this.applicant_lbl1.Name = "applicant_lbl1";
            this.applicant_lbl1.Size = new System.Drawing.Size(217, 32);
            this.applicant_lbl1.TabIndex = 1;
            this.applicant_lbl1.Text = "Notification Form";
            // 
            // applicant_datagrdvw1
            // 
            this.applicant_datagrdvw1.AllowUserToAddRows = false;
            this.applicant_datagrdvw1.AllowUserToDeleteRows = false;
            this.applicant_datagrdvw1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applicant_datagrdvw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.applicant_datagrdvw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicant_datagrdvw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.applicant_datagrdvw1.Location = new System.Drawing.Point(34, 58);
            this.applicant_datagrdvw1.Name = "applicant_datagrdvw1";
            this.applicant_datagrdvw1.ReadOnly = true;
            this.applicant_datagrdvw1.Size = new System.Drawing.Size(598, 434);
            this.applicant_datagrdvw1.TabIndex = 2;
            this.applicant_datagrdvw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Job Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Application Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(364, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // applicant_txtbx1
            // 
            this.applicant_txtbx1.BackColor = System.Drawing.SystemColors.Control;
            this.applicant_txtbx1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicant_txtbx1.Location = new System.Drawing.Point(430, 34);
            this.applicant_txtbx1.Name = "applicant_txtbx1";
            this.applicant_txtbx1.Size = new System.Drawing.Size(202, 22);
            this.applicant_txtbx1.TabIndex = 1;
            this.applicant_txtbx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // applicant_notif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 550);
            this.Controls.Add(this.applicant_txtbx1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicant_datagrdvw1);
            this.Controls.Add(this.applicant_lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "applicant_notif";
            this.Text = "applicant_notif";
            this.Load += new System.EventHandler(this.applicant_notif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicant_datagrdvw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applicant_lbl1;
        private System.Windows.Forms.DataGridView applicant_datagrdvw1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox applicant_txtbx1;
    }
}