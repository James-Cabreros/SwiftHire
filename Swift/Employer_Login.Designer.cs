namespace Swift
{
    partial class Employer_Login
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employer_Login));
            this.Employer_pnl1 = new System.Windows.Forms.Panel();
            this.employer_bkbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employer_txtbx1 = new System.Windows.Forms.TextBox();
            this.employer_txtbx2 = new System.Windows.Forms.TextBox();
            this.employer_chbx1 = new System.Windows.Forms.CheckBox();
            this.employer_btn1 = new System.Windows.Forms.Button();
            this.employer_lnklbl1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            this.Employer_pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Open Sans Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(121, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 39);
            label1.TabIndex = 1;
            label1.Text = "Company Log-in";
            // 
            // Employer_pnl1
            // 
            this.Employer_pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.Employer_pnl1.Controls.Add(this.employer_bkbtn);
            this.Employer_pnl1.Controls.Add(label1);
            this.Employer_pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employer_pnl1.Location = new System.Drawing.Point(0, 0);
            this.Employer_pnl1.Name = "Employer_pnl1";
            this.Employer_pnl1.Size = new System.Drawing.Size(484, 91);
            this.Employer_pnl1.TabIndex = 0;
            // 
            // employer_bkbtn
            // 
            this.employer_bkbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.employer_bkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employer_bkbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.employer_bkbtn.Image = ((System.Drawing.Image)(resources.GetObject("employer_bkbtn.Image")));
            this.employer_bkbtn.Location = new System.Drawing.Point(456, 0);
            this.employer_bkbtn.Name = "employer_bkbtn";
            this.employer_bkbtn.Size = new System.Drawing.Size(28, 28);
            this.employer_bkbtn.TabIndex = 5;
            this.employer_bkbtn.UseVisualStyleBackColor = false;
            this.employer_bkbtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(101, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(96, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // employer_txtbx1
            // 
            this.employer_txtbx1.BackColor = System.Drawing.SystemColors.Control;
            this.employer_txtbx1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_txtbx1.Location = new System.Drawing.Point(193, 151);
            this.employer_txtbx1.Name = "employer_txtbx1";
            this.employer_txtbx1.Size = new System.Drawing.Size(197, 25);
            this.employer_txtbx1.TabIndex = 1;
            // 
            // employer_txtbx2
            // 
            this.employer_txtbx2.BackColor = System.Drawing.SystemColors.Control;
            this.employer_txtbx2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_txtbx2.Location = new System.Drawing.Point(193, 193);
            this.employer_txtbx2.Name = "employer_txtbx2";
            this.employer_txtbx2.Size = new System.Drawing.Size(197, 25);
            this.employer_txtbx2.TabIndex = 2;
            this.employer_txtbx2.UseSystemPasswordChar = true;
            this.employer_txtbx2.TextChanged += new System.EventHandler(this.employer_txtbx2_TextChanged);
            // 
            // employer_chbx1
            // 
            this.employer_chbx1.AutoSize = true;
            this.employer_chbx1.BackColor = System.Drawing.Color.Transparent;
            this.employer_chbx1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_chbx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.employer_chbx1.Location = new System.Drawing.Point(193, 220);
            this.employer_chbx1.Name = "employer_chbx1";
            this.employer_chbx1.Size = new System.Drawing.Size(97, 19);
            this.employer_chbx1.TabIndex = 4;
            this.employer_chbx1.Text = "See password";
            this.employer_chbx1.UseVisualStyleBackColor = false;
            this.employer_chbx1.CheckedChanged += new System.EventHandler(this.employer_chbx1_CheckedChanged);
            // 
            // employer_btn1
            // 
            this.employer_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.employer_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employer_btn1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.employer_btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employer_btn1.Location = new System.Drawing.Point(193, 255);
            this.employer_btn1.Name = "employer_btn1";
            this.employer_btn1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.employer_btn1.Size = new System.Drawing.Size(197, 38);
            this.employer_btn1.TabIndex = 3;
            this.employer_btn1.Text = "Log-in";
            this.employer_btn1.UseVisualStyleBackColor = false;
            this.employer_btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // employer_lnklbl1
            // 
            this.employer_lnklbl1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.employer_lnklbl1.AutoSize = true;
            this.employer_lnklbl1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employer_lnklbl1.LinkColor = System.Drawing.Color.Transparent;
            this.employer_lnklbl1.Location = new System.Drawing.Point(80, 278);
            this.employer_lnklbl1.Name = "employer_lnklbl1";
            this.employer_lnklbl1.Size = new System.Drawing.Size(101, 15);
            this.employer_lnklbl1.TabIndex = 5;
            this.employer_lnklbl1.TabStop = true;
            this.employer_lnklbl1.Text = "Create an Account";
            this.employer_lnklbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(296, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Employer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.employer_lnklbl1);
            this.Controls.Add(this.employer_chbx1);
            this.Controls.Add(this.employer_btn1);
            this.Controls.Add(this.employer_txtbx2);
            this.Controls.Add(this.employer_txtbx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Employer_pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employer_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employer_Login";
            this.Load += new System.EventHandler(this.Employer_Login_Load);
            this.Employer_pnl1.ResumeLayout(false);
            this.Employer_pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Employer_pnl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employer_txtbx1;
        private System.Windows.Forms.TextBox employer_txtbx2;
        private System.Windows.Forms.Button employer_btn1;
        private System.Windows.Forms.Button employer_bkbtn;
        private System.Windows.Forms.CheckBox employer_chbx1;
        private System.Windows.Forms.LinkLabel employer_lnklbl1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}