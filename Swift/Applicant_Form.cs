using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift
{
    public partial class Applicant_Form : Form
    {
        public Applicant_Form()
        {
            InitializeComponent();
        }

        public string ApplicantName { get; set; } // Rename to ApplicantName

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Applicant_Form_Load(object sender, EventArgs e)
        {
            // Automatically load the applicant_post form into applicant_pnl3 when the form loads
            Loadform(new applicant_post());
            // Display the applicant's name in the label
            Applicant_name.Text = ApplicantName;
        }

        public void Loadform(object Form)
        {
            if (this.applicant_pnl3.Controls.Count > 0)
                this.applicant_pnl3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.applicant_pnl3.Controls.Add(f);
            this.applicant_pnl3.Tag = f;
            f.Show();
        }

        private void Applicant_lbl1_Click(object sender, EventArgs e)
        {
            // Fetch applicant's name from the database (if needed)
        }

        private void Applicant_pnl3_Paint(object sender, PaintEventArgs e)
        {
            // Currently empty
        }

        private void Applicant_btn3_Click(object sender, EventArgs e)
        {
            Opening_form Backhome3 = new Opening_form();
            Backhome3.Show();
            this.Hide();
        }

        private void applicant_btn1_Click(object sender, EventArgs e)
        {
            Loadform(new applicant_post());
        }

        private void applicant_btn2_Click(object sender, EventArgs e)
        {
            Loadform(new applicant_notif());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Currently empty
        }
    }
}
