﻿using System;
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
                MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM `employer_info` WHERE name = @username AND password = @password";
                    command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@username", employer_txtbx1.Text);
                    command.Parameters.AddWithValue("@password", employer_txtbx2.Text);

                    Console.WriteLine("Query: " + selectQuery); // Print the query for debugging
                    Console.WriteLine("name: " + employer_txtbx1.Text); // Print the username for debugging
                    Console.WriteLine("Password: " + employer_txtbx2.Text); // Print the password for debugging

                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Employer_form form2 = new Employer_form();       
                        form2.EmployerName = employer_txtbx1.Text;
                        form2.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employer_regis employer_Regis = new employer_regis();
            employer_Regis.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            employer_forgot employer_Forgot = new employer_forgot();
            employer_Forgot.Show();
            this.Hide();
        }
    }
}
