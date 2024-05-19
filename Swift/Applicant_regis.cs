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
    public partial class Applicant_regis : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;

        public Applicant_regis()
        {
            InitializeComponent();
            SetBackground();
        }

        private void SetBackground()
        {
            // Create a LinearGradientBrush for the background
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(2, 0, 36),
                Color.FromArgb(0, 212, 255),
                LinearGradientMode.Horizontal);

            // Set the background of the form to the LinearGradientBrush
            this.BackgroundImage = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(this.BackgroundImage);
            graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }

        private void Applicant_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Opening_form BackHome1 = new Opening_form();
            BackHome1.Show();
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            // No code needed here for now
        }

        private void A_Password_TextChanged(object sender, EventArgs e)
        {
            // No code needed here for now
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string countQuery = "SELECT COUNT(*) FROM applicant_info";
            command = new MySqlCommand(countQuery, connection);
            int userCount = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            Applicant_txtbx1.Text = "";
            Applicant_txtbx2.Text = "";
            Applicant_txtbx3.Text = "";



            if (userCount >= 1)
            {
                MessageBox.Show("Sorry, registration is closed. Maximum number of users reached.");
                return;
               
            }

            if (string.IsNullOrEmpty(Applicant_txtbx1.Text) || string.IsNullOrEmpty(Applicant_txtbx2.Text) || string.IsNullOrEmpty(Applicant_txtbx3.Text))
            {
                MessageBox.Show("Please fill all the information", "Error");
                Applicant_txtbx1.Text = "";
                Applicant_txtbx2.Text = "";
                Applicant_txtbx3.Text = "";
            }
            else if (Applicant_txtbx2.Text != Applicant_txtbx3.Text)
            {
                MessageBox.Show("Passwords do not match", "Error");
                Applicant_txtbx1.Text = "";
                Applicant_txtbx2.Text = "";
                Applicant_txtbx3.Text = "";
            }
            else
            {
                connection.Open();
                string insertQuery = "INSERT INTO applicant_info (username, password) VALUES (@username, @password)";
                command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@username", Applicant_txtbx1.Text);
                command.Parameters.AddWithValue("@password", Applicant_txtbx2.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registration Successful! You can now login.");

                Applicant_txtbx1.Text = ""; 
                Applicant_txtbx2.Text = "";
                Applicant_txtbx3.Text = "";
            }
            
        }

        private void Applicant_chbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (Applicant_chbx1.Checked)
            {
                Applicant_txtbx2.UseSystemPasswordChar = false;
                Applicant_txtbx3.UseSystemPasswordChar = false;
            }
            else
            {
                Applicant_txtbx2.UseSystemPasswordChar = true;
                Applicant_txtbx3.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Applicant_login applicant_Login = new Applicant_login();
            applicant_Login.Show();
            this.Hide();
        }

        private void Applicant_txtbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicant_lbl9_Click(object sender, EventArgs e)
        {

        }

        private void applicant_lbl8_Click(object sender, EventArgs e)
        {

        }

        private void Applicant_txtbx2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
