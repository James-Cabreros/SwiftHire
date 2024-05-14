using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Swift
{
    public partial class Employer_Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Employer_Login()
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Opening_form BackHome2 = new Opening_form();
            BackHome2.Show();
            this.Close();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employer_txtbx1.Text) || string.IsNullOrEmpty(employer_txtbx2.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM `employer_info` WHERE name = @username AND password = @password";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@username", employer_txtbx1.Text);
                command.Parameters.AddWithValue("@password", employer_txtbx2.Text);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Employer_form form2 = new Employer_form();
                    form2.ShowDialog();
                }
                else
                {
                    connection.Close(); // Close the previous connection before opening a new one for the update

                    // Check the number of existing users
                    connection.Open();
                    string countQuery = "SELECT COUNT(*) FROM `employer_info`";
                    command = new MySqlCommand(countQuery, connection);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    if (userCount < 2)
                    {
                        // Proceed with registration if the maximum number of users has not been reached
                        connection.Open();
                        string insertQuery = "INSERT INTO `employer_info` (name, Password) VALUES (@username, @password)";
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@username", employer_txtbx1.Text);
                        command.Parameters.AddWithValue("@password", employer_txtbx2.Text);
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





        private void employer_chbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (employer_chbx1.Checked)
            {
                employer_txtbx2.UseSystemPasswordChar = false;
            }
            else
            {
                employer_txtbx2.UseSystemPasswordChar = true;
            }
        }

        private void employer_txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void employer_btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employer_form form3 = new Employer_form();
            form3.ShowDialog();
        }

        private void Employer_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
