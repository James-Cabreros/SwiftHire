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

        }

       

        private void A_Username_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void A_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string countQuery = "SELECT COUNT(*) FROM applicant_info";
            command = new MySqlCommand(countQuery, connection);
            int userCount = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if (userCount >= 2)
            {
                MessageBox.Show("Sorry, registration is closed. Maximum number of users reached.");
                return;
            }

            if (string.IsNullOrEmpty(Applicant_txtbx1.Text) || string.IsNullOrEmpty(Applicant_txtbx2.Text) || string.IsNullOrEmpty(Applicant_txtbx3.Text) ||
                string.IsNullOrEmpty(Applicant_txtbx4.Text) || string.IsNullOrEmpty(Applicant_txtbx5.Text) || string.IsNullOrEmpty(applicant_date1.Text))
            {
                MessageBox.Show("Please fill all the information", "Error");
            }
            else if (Applicant_txtbx5.Text != Applicant_txtbx6.Text)
            {
                MessageBox.Show("Passwords do not match", "Error");
            }
            else
            {
                connection.Open();
                string insertQuery = "INSERT INTO applicant_info (f_name, l_name, address, email, password, b_date) VALUES (@f_name, @l_name, @address, @email, @password, @b_date)";
                command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@f_name", Applicant_txtbx1.Text);
                command.Parameters.AddWithValue("@l_name", Applicant_txtbx2.Text);
                command.Parameters.AddWithValue("@address", Applicant_txtbx3.Text);
                command.Parameters.AddWithValue("@email", Applicant_txtbx4.Text);
                command.Parameters.AddWithValue("@password", Applicant_txtbx5.Text);
                command.Parameters.AddWithValue("@b_date", applicant_date1.Value.ToString("yyyy-MM-dd")); // Assuming applicant_date1 is a DateTimePicker

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Registration Successful! You can now login.");
                

            }
        }






        private void Applicant_chbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (Applicant_chbx1.Checked)
            {
                Applicant_txtbx5.UseSystemPasswordChar = false;
                Applicant_txtbx6.UseSystemPasswordChar = false;
            }
            else
            {
                Applicant_txtbx5.UseSystemPasswordChar = true;
                Applicant_txtbx6.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Applicant_login applicant_Login = new Applicant_login();
            applicant_Login.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
