﻿namespace Swift
{
    partial class Applicant_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicant_Login));
            this.applicant_pnl1 = new System.Windows.Forms.Panel();
            this.Applicant_lbl1 = new System.Windows.Forms.Label();
            this.Applicant_bkbtn = new System.Windows.Forms.Button();
            this.Applicant_lbl2 = new System.Windows.Forms.Label();
            this.Applicant_lbl3 = new System.Windows.Forms.Label();
            this.Applicant_txtbx1 = new System.Windows.Forms.TextBox();
            this.Applicant_txtbx2 = new System.Windows.Forms.TextBox();
            this.Signin_btn = new System.Windows.Forms.Button();
            this.applicant_pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicant_pnl1
            // 
            this.applicant_pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.applicant_pnl1.Controls.Add(this.Applicant_lbl1);
            this.applicant_pnl1.Controls.Add(this.Applicant_bkbtn);
            this.applicant_pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicant_pnl1.Location = new System.Drawing.Point(0, 0);
            this.applicant_pnl1.Name = "applicant_pnl1";
            this.applicant_pnl1.Size = new System.Drawing.Size(484, 91);
            this.applicant_pnl1.TabIndex = 4;
            // 
            // Applicant_lbl1
            // 
            this.Applicant_lbl1.AutoSize = true;
            this.Applicant_lbl1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applicant_lbl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Applicant_lbl1.Location = new System.Drawing.Point(106, 29);
            this.Applicant_lbl1.Name = "Applicant_lbl1";
            this.Applicant_lbl1.Size = new System.Drawing.Size(252, 40);
            this.Applicant_lbl1.TabIndex = 2;
            this.Applicant_lbl1.Text = "Applicant Sign-in";
            // 
            // Applicant_bkbtn
            // 
            this.Applicant_bkbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_bkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Applicant_bkbtn.Image = ((System.Drawing.Image)(resources.GetObject("Applicant_bkbtn.Image")));
            this.Applicant_bkbtn.Location = new System.Drawing.Point(456, 0);
            this.Applicant_bkbtn.Name = "Applicant_bkbtn";
            this.Applicant_bkbtn.Size = new System.Drawing.Size(28, 28);
            this.Applicant_bkbtn.TabIndex = 8;
            this.Applicant_bkbtn.UseVisualStyleBackColor = false;
            this.Applicant_bkbtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Applicant_lbl2
            // 
            this.Applicant_lbl2.AutoSize = true;
            this.Applicant_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.Applicant_lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applicant_lbl2.ForeColor = System.Drawing.Color.Transparent;
            this.Applicant_lbl2.Location = new System.Drawing.Point(40, 146);
            this.Applicant_lbl2.Name = "Applicant_lbl2";
            this.Applicant_lbl2.Size = new System.Drawing.Size(115, 30);
            this.Applicant_lbl2.TabIndex = 9;
            this.Applicant_lbl2.Text = "Username:";
            // 
            // Applicant_lbl3
            // 
            this.Applicant_lbl3.AutoSize = true;
            this.Applicant_lbl3.BackColor = System.Drawing.Color.Transparent;
            this.Applicant_lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applicant_lbl3.ForeColor = System.Drawing.Color.Transparent;
            this.Applicant_lbl3.Location = new System.Drawing.Point(40, 189);
            this.Applicant_lbl3.Name = "Applicant_lbl3";
            this.Applicant_lbl3.Size = new System.Drawing.Size(109, 30);
            this.Applicant_lbl3.TabIndex = 10;
            this.Applicant_lbl3.Text = "Password:";
            this.Applicant_lbl3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Applicant_txtbx1
            // 
            this.Applicant_txtbx1.Location = new System.Drawing.Point(161, 153);
            this.Applicant_txtbx1.Name = "Applicant_txtbx1";
            this.Applicant_txtbx1.Size = new System.Drawing.Size(196, 20);
            this.Applicant_txtbx1.TabIndex = 11;
            this.Applicant_txtbx1.TextChanged += new System.EventHandler(this.A_Username_TextChanged);
            // 
            // Applicant_txtbx2
            // 
            this.Applicant_txtbx2.Location = new System.Drawing.Point(162, 199);
            this.Applicant_txtbx2.Name = "Applicant_txtbx2";
            this.Applicant_txtbx2.Size = new System.Drawing.Size(196, 20);
            this.Applicant_txtbx2.TabIndex = 12;
            this.Applicant_txtbx2.TextChanged += new System.EventHandler(this.A_Password_TextChanged);
            // 
            // Signin_btn
            // 
            this.Signin_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signin_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Signin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Signin_btn.Location = new System.Drawing.Point(205, 240);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(110, 38);
            this.Signin_btn.TabIndex = 13;
            this.Signin_btn.Text = "Sign-in";
            this.Signin_btn.UseVisualStyleBackColor = false;
            this.Signin_btn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Applicant_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Signin_btn);
            this.Controls.Add(this.Applicant_txtbx2);
            this.Controls.Add(this.Applicant_txtbx1);
            this.Controls.Add(this.Applicant_lbl3);
            this.Controls.Add(this.Applicant_lbl2);
            this.Controls.Add(this.applicant_pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Applicant_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant_Login";
            this.Load += new System.EventHandler(this.Applicant_Login_Load);
            this.applicant_pnl1.ResumeLayout(false);
            this.applicant_pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel applicant_pnl1;
        private System.Windows.Forms.Label Applicant_lbl1;
        private System.Windows.Forms.Button Applicant_bkbtn;
        private System.Windows.Forms.Label Applicant_lbl2;
        private System.Windows.Forms.Label Applicant_lbl3;
        private System.Windows.Forms.TextBox Applicant_txtbx1;
        private System.Windows.Forms.TextBox Applicant_txtbx2;
        private System.Windows.Forms.Button Signin_btn;
    }
}