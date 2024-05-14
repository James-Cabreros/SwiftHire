namespace Swift
{
    partial class applicant_post
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
            this.Applicant_Datagrdvw1 = new System.Windows.Forms.DataGridView();
            this.Applicant_btn1 = new System.Windows.Forms.Button();
            this.applicant_lbl1 = new System.Windows.Forms.Label();
            this.applicant_txtbx1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_Datagrdvw1)).BeginInit();
            this.SuspendLayout();
            // 
            // Applicant_Datagrdvw1
            // 
            this.Applicant_Datagrdvw1.AllowUserToAddRows = false;
            this.Applicant_Datagrdvw1.AllowUserToDeleteRows = false;
            this.Applicant_Datagrdvw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Applicant_Datagrdvw1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Applicant_Datagrdvw1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Applicant_Datagrdvw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Applicant_Datagrdvw1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Applicant_Datagrdvw1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_Datagrdvw1.Location = new System.Drawing.Point(58, 96);
            this.Applicant_Datagrdvw1.Name = "Applicant_Datagrdvw1";
            this.Applicant_Datagrdvw1.ReadOnly = true;
            this.Applicant_Datagrdvw1.RowHeadersVisible = false;
            this.Applicant_Datagrdvw1.Size = new System.Drawing.Size(574, 302);
            this.Applicant_Datagrdvw1.TabIndex = 2;
            this.Applicant_Datagrdvw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Applicant_btn1
            // 
            this.Applicant_btn1.Location = new System.Drawing.Point(58, 447);
            this.Applicant_btn1.Name = "Applicant_btn1";
            this.Applicant_btn1.Size = new System.Drawing.Size(131, 42);
            this.Applicant_btn1.TabIndex = 3;
            this.Applicant_btn1.Text = "read";
            this.Applicant_btn1.UseVisualStyleBackColor = true;
            this.Applicant_btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicant_lbl1
            // 
            this.applicant_lbl1.AutoSize = true;
            this.applicant_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicant_lbl1.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Location = new System.Drawing.Point(61, 42);
            this.applicant_lbl1.Name = "applicant_lbl1";
            this.applicant_lbl1.Size = new System.Drawing.Size(105, 37);
            this.applicant_lbl1.TabIndex = 4;
            this.applicant_lbl1.Text = "Search:";
            // 
            // applicant_txtbx1
            // 
            this.applicant_txtbx1.Location = new System.Drawing.Point(172, 58);
            this.applicant_txtbx1.Multiline = true;
            this.applicant_txtbx1.Name = "applicant_txtbx1";
            this.applicant_txtbx1.Size = new System.Drawing.Size(459, 21);
            this.applicant_txtbx1.TabIndex = 5;
            this.applicant_txtbx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 47;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Job Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Job Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Contact Information";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 153;
            // 
            // applicant_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 550);
            this.Controls.Add(this.applicant_txtbx1);
            this.Controls.Add(this.applicant_lbl1);
            this.Controls.Add(this.Applicant_btn1);
            this.Controls.Add(this.Applicant_Datagrdvw1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "applicant_post";
            this.Text = "applicant_post";
            this.Load += new System.EventHandler(this.applicant_post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Applicant_Datagrdvw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Applicant_Datagrdvw1;
        private System.Windows.Forms.Button Applicant_btn1;
        private System.Windows.Forms.Label applicant_lbl1;
        private System.Windows.Forms.TextBox applicant_txtbx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}