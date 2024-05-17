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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applicant_btn1 = new System.Windows.Forms.Button();
            this.applicant_lbl1 = new System.Windows.Forms.Label();
            this.applicant_txtbx1 = new System.Windows.Forms.TextBox();
            this.applicant_txtbx2 = new System.Windows.Forms.TextBox();
            this.applicant_lbl2 = new System.Windows.Forms.Label();
            this.applicant_txtbx3 = new System.Windows.Forms.TextBox();
            this.applicant_lbl3 = new System.Windows.Forms.Label();
            this.applicant_btn2 = new System.Windows.Forms.Button();
            this.applicant_lbl4 = new System.Windows.Forms.Label();
            this.applicant_txtbx4 = new System.Windows.Forms.TextBox();
            this.applicant_rtxtbx1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Applicant_btn3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.applicant_txtbx5 = new System.Windows.Forms.TextBox();
            this.applicant_lbl5 = new System.Windows.Forms.Label();
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
            this.Applicant_Datagrdvw1.Location = new System.Drawing.Point(172, 53);
            this.Applicant_Datagrdvw1.Name = "Applicant_Datagrdvw1";
            this.Applicant_Datagrdvw1.ReadOnly = true;
            this.Applicant_Datagrdvw1.RowHeadersVisible = false;
            this.Applicant_Datagrdvw1.Size = new System.Drawing.Size(459, 458);
            this.Applicant_Datagrdvw1.TabIndex = 2;
            this.Applicant_Datagrdvw1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Applicant_btn1
            // 
            this.Applicant_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Applicant_btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Applicant_btn1.ForeColor = System.Drawing.Color.Transparent;
            this.Applicant_btn1.Location = new System.Drawing.Point(12, 419);
            this.Applicant_btn1.Name = "Applicant_btn1";
            this.Applicant_btn1.Size = new System.Drawing.Size(140, 42);
            this.Applicant_btn1.TabIndex = 3;
            this.Applicant_btn1.Text = "Apply";
            this.Applicant_btn1.UseVisualStyleBackColor = false;
            this.Applicant_btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicant_lbl1
            // 
            this.applicant_lbl1.AutoSize = true;
            this.applicant_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl1.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl1.Location = new System.Drawing.Point(168, 16);
            this.applicant_lbl1.Name = "applicant_lbl1";
            this.applicant_lbl1.Size = new System.Drawing.Size(95, 32);
            this.applicant_lbl1.TabIndex = 4;
            this.applicant_lbl1.Text = "Search:";
            // 
            // applicant_txtbx1
            // 
            this.applicant_txtbx1.Location = new System.Drawing.Point(262, 26);
            this.applicant_txtbx1.Name = "applicant_txtbx1";
            this.applicant_txtbx1.Size = new System.Drawing.Size(369, 20);
            this.applicant_txtbx1.TabIndex = 5;
            this.applicant_txtbx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // applicant_txtbx2
            // 
            this.applicant_txtbx2.Location = new System.Drawing.Point(12, 79);
            this.applicant_txtbx2.Name = "applicant_txtbx2";
            this.applicant_txtbx2.Size = new System.Drawing.Size(140, 20);
            this.applicant_txtbx2.TabIndex = 6;
            this.applicant_txtbx2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // applicant_lbl2
            // 
            this.applicant_lbl2.AutoSize = true;
            this.applicant_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl2.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl2.Location = new System.Drawing.Point(14, 53);
            this.applicant_lbl2.Name = "applicant_lbl2";
            this.applicant_lbl2.Size = new System.Drawing.Size(31, 21);
            this.applicant_lbl2.TabIndex = 7;
            this.applicant_lbl2.Text = "ID:";
            // 
            // applicant_txtbx3
            // 
            this.applicant_txtbx3.Location = new System.Drawing.Point(12, 126);
            this.applicant_txtbx3.Name = "applicant_txtbx3";
            this.applicant_txtbx3.Size = new System.Drawing.Size(140, 20);
            this.applicant_txtbx3.TabIndex = 8;
            this.applicant_txtbx3.TextChanged += new System.EventHandler(this.applicant_txtbx3_TextChanged);
            // 
            // applicant_lbl3
            // 
            this.applicant_lbl3.AutoSize = true;
            this.applicant_lbl3.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl3.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl3.Location = new System.Drawing.Point(13, 101);
            this.applicant_lbl3.Name = "applicant_lbl3";
            this.applicant_lbl3.Size = new System.Drawing.Size(71, 21);
            this.applicant_lbl3.TabIndex = 9;
            this.applicant_lbl3.Text = "Job Title";
            // 
            // applicant_btn2
            // 
            this.applicant_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.applicant_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applicant_btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_btn2.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_btn2.Location = new System.Drawing.Point(12, 467);
            this.applicant_btn2.Name = "applicant_btn2";
            this.applicant_btn2.Size = new System.Drawing.Size(140, 42);
            this.applicant_btn2.TabIndex = 10;
            this.applicant_btn2.Text = "Refresh Table";
            this.applicant_btn2.UseVisualStyleBackColor = false;
            this.applicant_btn2.Click += new System.EventHandler(this.applicant_btn2_Click);
            // 
            // applicant_lbl4
            // 
            this.applicant_lbl4.AutoSize = true;
            this.applicant_lbl4.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl4.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl4.Location = new System.Drawing.Point(14, 150);
            this.applicant_lbl4.Name = "applicant_lbl4";
            this.applicant_lbl4.Size = new System.Drawing.Size(88, 21);
            this.applicant_lbl4.TabIndex = 12;
            this.applicant_lbl4.Text = "Full Name:";
            // 
            // applicant_txtbx4
            // 
            this.applicant_txtbx4.Location = new System.Drawing.Point(12, 174);
            this.applicant_txtbx4.Name = "applicant_txtbx4";
            this.applicant_txtbx4.Size = new System.Drawing.Size(140, 20);
            this.applicant_txtbx4.TabIndex = 14;
            // 
            // applicant_rtxtbx1
            // 
            this.applicant_rtxtbx1.Location = new System.Drawing.Point(12, 294);
            this.applicant_rtxtbx1.Name = "applicant_rtxtbx1";
            this.applicant_rtxtbx1.Size = new System.Drawing.Size(140, 32);
            this.applicant_rtxtbx1.TabIndex = 16;
            this.applicant_rtxtbx1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Upload CV:";
            // 
            // Applicant_btn3
            // 
            this.Applicant_btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Applicant_btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Applicant_btn3.ForeColor = System.Drawing.Color.Transparent;
            this.Applicant_btn3.Location = new System.Drawing.Point(12, 333);
            this.Applicant_btn3.Name = "Applicant_btn3";
            this.Applicant_btn3.Size = new System.Drawing.Size(140, 42);
            this.Applicant_btn3.TabIndex = 18;
            this.Applicant_btn3.Text = "Browse";
            this.Applicant_btn3.UseVisualStyleBackColor = false;
            this.Applicant_btn3.Click += new System.EventHandler(this.Applicant_btn3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // applicant_txtbx5
            // 
            this.applicant_txtbx5.Location = new System.Drawing.Point(12, 241);
            this.applicant_txtbx5.Name = "applicant_txtbx5";
            this.applicant_txtbx5.Size = new System.Drawing.Size(140, 20);
            this.applicant_txtbx5.TabIndex = 20;
            // 
            // applicant_lbl5
            // 
            this.applicant_lbl5.AutoSize = true;
            this.applicant_lbl5.BackColor = System.Drawing.Color.Transparent;
            this.applicant_lbl5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.applicant_lbl5.ForeColor = System.Drawing.Color.Transparent;
            this.applicant_lbl5.Location = new System.Drawing.Point(14, 195);
            this.applicant_lbl5.Name = "applicant_lbl5";
            this.applicant_lbl5.Size = new System.Drawing.Size(100, 42);
            this.applicant_lbl5.TabIndex = 19;
            this.applicant_lbl5.Text = "Contact \r\nInformation:";
            // 
            // applicant_post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 550);
            this.Controls.Add(this.applicant_txtbx5);
            this.Controls.Add(this.applicant_lbl5);
            this.Controls.Add(this.Applicant_btn3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicant_rtxtbx1);
            this.Controls.Add(this.applicant_txtbx4);
            this.Controls.Add(this.applicant_lbl4);
            this.Controls.Add(this.applicant_btn2);
            this.Controls.Add(this.applicant_lbl3);
            this.Controls.Add(this.applicant_txtbx3);
            this.Controls.Add(this.applicant_lbl2);
            this.Controls.Add(this.applicant_txtbx2);
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
        private System.Windows.Forms.TextBox applicant_txtbx2;
        private System.Windows.Forms.Label applicant_lbl2;
        private System.Windows.Forms.TextBox applicant_txtbx3;
        private System.Windows.Forms.Label applicant_lbl3;
        private System.Windows.Forms.Button applicant_btn2;
        private System.Windows.Forms.Label applicant_lbl4;
        private System.Windows.Forms.TextBox applicant_txtbx4;
        private System.Windows.Forms.RichTextBox applicant_rtxtbx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Applicant_btn3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox applicant_txtbx5;
        private System.Windows.Forms.Label applicant_lbl5;
    }
}