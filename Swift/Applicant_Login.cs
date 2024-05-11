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
    public partial class Applicant_Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=applicant_login");
        MySqlCommand command;
        MySqlDataReader mdr;


        public Applicant_Login()
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
            if (string.IsNullOrEmpty(Applicant_txtbx1.Text) || string.IsNullOrEmpty(Applicant_txtbx2.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM `a_login-id` WHERE Username = @username AND Password = @password";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@username", Applicant_txtbx1.Text);
                command.Parameters.AddWithValue("@password", Applicant_txtbx2.Text);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Applicant_Form form2 = new Applicant_Form();
                    form2.ShowDialog();
                }
                else
                {
                    connection.Close(); // Close the previous connection before opening a new one for the update

                    // Check the number of existing users
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) FROM `a_login-id`";
                    command = new MySqlCommand(countQuery, connection);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    if (userCount < 2)
                    {
                        // Proceed with registration if the maximum number of users has not been reached
                        connection.Open();
                        string insertQuery = "INSERT INTO `a_login-id` (Username, Password) VALUES (@username, @password)";
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@username", Applicant_txtbx1.Text);
                        command.Parameters.AddWithValue("@password", Applicant_txtbx2.Text);
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Registration Successful! You can now login.");
                    }
                    else
                    {
                        MessageBox.Show("something's not right with the username or password you entered.");
                    }
                }
            }
        }

        private void Applicant_chbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (Applicant_chbx1.Checked)
            {
                Applicant_txtbx2.UseSystemPasswordChar = false;
            }
            else
            {
                Applicant_txtbx2.UseSystemPasswordChar = true;
            }
        }
    }
}
