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
    public partial class Employer_form : Form
    {


        
        public Employer_form()
        {
            InitializeComponent();
           
        }

        public string EmployerName { get; set; }


        private void Employer_form_Load(object sender, EventArgs e)
        {
            Loadform(new Employer_post());

            Employer_name.Text = EmployerName;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Opening_form backhome4 = new Opening_form();
            backhome4.Show();
            this.Hide();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employer_pnl3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Employer_pnl2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Loadform(object Form)
        {
            if (this.employer_pnl3.Controls.Count >0)
                this.employer_pnl3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.employer_pnl3.Controls.Add(f);
            this.employer_pnl3.Tag = f;
            f.Show();
        }

        private void Employer_btn1_Click(object sender, EventArgs e)
        {
            Loadform(new Employer_post());
        }

        private void Employer_btn2_Click(object sender, EventArgs e)
        {
            Loadform(new Employer_notif());
        }

        private void Employer_btn3_Click(object sender, EventArgs e)
        {
            Opening_form backhome4 = new Opening_form();
            backhome4.Show();
            this.Hide();
        }
    }
}
