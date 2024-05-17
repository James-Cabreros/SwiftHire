namespace Swift
{
    partial class Opening_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opening_form));
            this.Applicant_btn = new System.Windows.Forms.Button();
            this.SwiftHire_lbl = new System.Windows.Forms.Label();
            this.Employer_btn = new System.Windows.Forms.Button();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.Sign_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Applicant_btn
            // 
            this.Applicant_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Applicant_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Applicant_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applicant_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Applicant_btn.Location = new System.Drawing.Point(344, 191);
            this.Applicant_btn.Name = "Applicant_btn";
            this.Applicant_btn.Size = new System.Drawing.Size(121, 49);
            this.Applicant_btn.TabIndex = 0;
            this.Applicant_btn.Text = "Applicant";
            this.Applicant_btn.UseVisualStyleBackColor = false;
            this.Applicant_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SwiftHire_lbl
            // 
            this.SwiftHire_lbl.AutoSize = true;
            this.SwiftHire_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SwiftHire_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwiftHire_lbl.Location = new System.Drawing.Point(68, 15);
            this.SwiftHire_lbl.Name = "SwiftHire_lbl";
            this.SwiftHire_lbl.Size = new System.Drawing.Size(496, 65);
            this.SwiftHire_lbl.TabIndex = 1;
            this.SwiftHire_lbl.Text = "Welcome to SwiftHire";
            this.SwiftHire_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SwiftHire_lbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Employer_btn
            // 
            this.Employer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Employer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Employer_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employer_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Employer_btn.Location = new System.Drawing.Point(486, 191);
            this.Employer_btn.Name = "Employer_btn";
            this.Employer_btn.Size = new System.Drawing.Size(121, 49);
            this.Employer_btn.TabIndex = 2;
            this.Employer_btn.Text = "Employer";
            this.Employer_btn.UseVisualStyleBackColor = false;
            this.Employer_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.desc_lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.desc_lbl.Location = new System.Drawing.Point(44, 141);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(272, 135);
            this.desc_lbl.TabIndex = 3;
            this.desc_lbl.Text = "“Your swift and \r\nconvinient job \r\napplication portal”";
            this.desc_lbl.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Sign_lbl
            // 
            this.Sign_lbl.AutoSize = true;
            this.Sign_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Sign_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.Sign_lbl.Location = new System.Drawing.Point(339, 141);
            this.Sign_lbl.Name = "Sign_lbl";
            this.Sign_lbl.Size = new System.Drawing.Size(122, 30);
            this.Sign_lbl.TabIndex = 4;
            this.Sign_lbl.Text = "Register as:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.SwiftHire_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 90);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(652, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(32, 33);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Opening_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sign_lbl);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.Employer_btn);
            this.Controls.Add(this.Applicant_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Opening_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwiftHire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Applicant_btn;
        private System.Windows.Forms.Label SwiftHire_lbl;
        private System.Windows.Forms.Button Employer_btn;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label Sign_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_btn;
    }
}

