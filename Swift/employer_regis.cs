﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Swift
{
    public partial class employer_regis : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;

        public employer_regis()
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

        private void Applicant_txtbx2_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event logic if needed
        }

        private void applicant_btn1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM employer_info";
                command = new MySqlCommand(countQuery, connection);
                int userCount = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                if (userCount >= 1)
                {
                    MessageBox.Show("Sorry, registration is closed. Maximum number of users reached.");
                    employer_txtbx1.Text = "";
                    employer_txtbx2.Text = "";
                    employer_txtbx3.Text = "";
                    return;
                }

                if (string.IsNullOrEmpty(employer_txtbx1.Text) || string.IsNullOrEmpty(employer_txtbx2.Text) || string.IsNullOrEmpty(employer_txtbx3.Text))
                {
                    MessageBox.Show("Please fill all the information", "Error");
                    employer_txtbx1.Text = "";
                    employer_txtbx2.Text = "";
                    employer_txtbx3.Text = "";
                }
                else if (employer_txtbx2.Text != employer_txtbx3.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error");
                    employer_txtbx1.Text = "";
                    employer_txtbx2.Text = "";
                    employer_txtbx3.Text = "";
                }
                else
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO employer_info (name, password) VALUES (@username, @password)";
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@username", employer_txtbx1.Text);
                    command.Parameters.AddWithValue("@password", employer_txtbx2.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Registration Successful! You can now login.");
                    employer_txtbx1.Text = "";
                    employer_txtbx2.Text = "";
                    employer_txtbx3.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Applicant_bkbtn_Click(object sender, EventArgs e)
        {
            Opening_form BackHome1 = new Opening_form();
            BackHome1.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employer_Login employer_login = new Employer_Login();
            employer_login.Show();
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

        private void employer_regis_Load(object sender, EventArgs e)
        {
            // Placeholder for form load event logic if needed
        }
    }
}
