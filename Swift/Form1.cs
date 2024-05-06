using System;
using System.Windows.Forms;

namespace Swift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Applicant_Login applicant_Login = new Applicant_Login();
            applicant_Login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employer_Login employer_Login = new Employer_Login();
            employer_Login.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Close the entire application
            }
        }
    }
}
