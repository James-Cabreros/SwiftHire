using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift
{
    public partial class employer_forgot : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader mdr;

        public employer_forgot()
        {
            InitializeComponent();
        }

        private void employer_forgot_Load(object sender, EventArgs e)
        {

        }

        private void employer_bkbtn_Click(object sender, EventArgs e)
        {
            Employer_Login employer_Login = new Employer_Login();
            employer_Login.Show();
            this.Hide();
        }

        private void employer_ckbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (employer_ckbx1.Checked)
            {
                employer_txtbx2.UseSystemPasswordChar = false;
                employer_txtbx3.UseSystemPasswordChar = false;
            }
            else
            {
                employer_txtbx2.UseSystemPasswordChar = true;
                employer_txtbx3.UseSystemPasswordChar = true;
            }
        }

        private void employer_btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employer_txtbx1.Text) || string.IsNullOrEmpty(employer_txtbx2.Text) || string.IsNullOrEmpty(employer_txtbx3.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (employer_txtbx2.Text != employer_txtbx3.Text)
            {
                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM `employer_info` WHERE name = @username";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@username", employer_txtbx1.Text);

                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    mdr.Close(); // Close the reader before executing another command

                    string updateQuery = "UPDATE `employer_info` SET password = @newPassword WHERE name = @username";
                    command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@username", employer_txtbx1.Text);
                    command.Parameters.AddWithValue("@newPassword", employer_txtbx2.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully!");

                    // Clear the text boxes
                    employer_txtbx1.Text = "";
                    employer_txtbx2.Text = "";
                    employer_txtbx3.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
