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
    public partial class Employer_Login : Form
    {
        public Employer_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 BackHome2 = new Form1();
            BackHome2.Show();
            this.Close();
        }

        private void Employer_Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
