using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift
{
    public partial class Applicant_Login : Form
    {
        public Applicant_Login()
        {
            InitializeComponent();
        }

        private void Applicant_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1  BackHome1 = new Form1();
            BackHome1.Show();
            this.Close();
        }
    }
}
