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
using MySql.Data.MySqlClient;

namespace Swift
{
    public partial class Applicant_login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Applicant_login()
        {
            InitializeComponent();
            
        }
       
        private void Applicant_login_Load(object sender, EventArgs e)
        {

        }

        private void applicant_bkbtn_Click(object sender, EventArgs e)
        {
            Opening_form BackHome5 = new Opening_form();
            BackHome5.Show();
            this.Close();
        }

        private void applicant_chbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (applicant_chbx1.Checked)
            {
                applicant_txtbx2.UseSystemPasswordChar = false;
            }
            else
            {
                applicant_txtbx2.UseSystemPasswordChar = true;
            }
        }

        private void Applicant_btn1_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(applicant_txtbx1.Text) || string.IsNullOrEmpty(applicant_txtbx2.Text))
             {
             MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        else
        {
            try
            {
             connection.Open();
            string selectQuery = "SELECT * FROM `applicant_info` WHERE username = @username AND password = @password";
            command = new MySqlCommand(selectQuery, connection);
            command.Parameters.AddWithValue("@username", applicant_txtbx1.Text);
            command.Parameters.AddWithValue("@password", applicant_txtbx2.Text);

            Console.WriteLine("Query: " + selectQuery); // Print the query for debugging
            Console.WriteLine("Username: " + applicant_txtbx1.Text); // Print the username for debugging
            Console.WriteLine("Password: " + applicant_txtbx2.Text); // Print the password for debugging

            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Login Successful!","Logged in",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                        // Create an instance of Applicant_Form
                        Applicant_Form form2 = new Applicant_Form();
                        // Set the value of ApplicantName
                        form2.ApplicantName = applicant_txtbx1.Text;
                        form2.ShowDialog();
                    }
            else
            {
                MessageBox.Show("Invalid username or password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
            {
                connection.Close();
            }
        }
    }

        private void applicant_txtbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Applicant_regis applicant_Regis = new Applicant_regis();
            applicant_Regis.Show();
            this.Hide();
        }

        private void applicant_lbl2_Click(object sender, EventArgs e)
        {

        }

        private void applicant_lnklbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            applicant_forgot applicant_Forgot = new applicant_forgot();
            applicant_Forgot.Show();
            this.Hide();
        }
    }
}
