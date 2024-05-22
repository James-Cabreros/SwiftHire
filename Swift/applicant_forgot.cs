using MySql.Data.MySqlClient;
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
    public partial class applicant_forgot : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader mdr;
        public applicant_forgot()
        {
            InitializeComponent();
        }

        private void applicant_forgot_Load(object sender, EventArgs e)
        {

        }

        private void applicant_bkbtn_Click(object sender, EventArgs e)
        {
            Applicant_login applicant_Login = new Applicant_login();
            applicant_Login.Show();
            this.Hide();
        }

        private void applicant_btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(applicant_txtbx1.Text) || string.IsNullOrEmpty(applicant_txtbx2.Text) || string.IsNullOrEmpty(applicant_txtbx3.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (applicant_txtbx2.Text != applicant_txtbx3.Text)
            {
                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM `applicant_info` WHERE username = @username";
                command = new MySqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@username", applicant_txtbx1.Text);

                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    mdr.Close(); // Close the reader before executing another command

                    string updateQuery = "UPDATE `applicant_info` SET password = @newPassword WHERE username = @username";
                    command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@username", applicant_txtbx1.Text);
                    command.Parameters.AddWithValue("@newPassword", applicant_txtbx2.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the text boxes
                    applicant_txtbx1.Text = "";
                    applicant_txtbx2.Text = "";
                    applicant_txtbx3.Text = "";
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

        private void employer_ckbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (applicant_ckbx1.Checked)
            {
                applicant_txtbx2.UseSystemPasswordChar = false;
            }
            else
            {
                applicant_txtbx2.UseSystemPasswordChar = true;
            }
        }
    }
}
