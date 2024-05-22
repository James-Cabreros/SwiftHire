
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;


namespace Swift
{
    public partial class Opening_form : Form
    {
        public Opening_form()
        {
            InitializeComponent();
            
            
        }

      

        private void Button1_Click(object sender, EventArgs e)
        {
            Applicant_login applicant_login = new Applicant_login();
            applicant_login.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Employer_Login employer_Login = new Employer_Login();
            employer_Login.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
