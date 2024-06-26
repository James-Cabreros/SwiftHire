﻿using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;



namespace Swift
{
    public partial class Employer_post : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader reader;

        public Employer_post()
        {
            InitializeComponent();
           
            PopulateComboBox();

            // Set ComboBox DropDownStyle to DropDownList to disable typing
            employer_cmbbx1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

     

        private void PopulateComboBox()
        {
            // Assuming these are the job titles
            string[] jobTitles = { "Software Developer", "Web Developer", "Mobile App Developer", "Database Administrator", "Front-End Developer", "Back-End Developer" };
            employer_cmbbx1.Items.AddRange(jobTitles);
        }

        private void Employer_post_Load(object sender, EventArgs e)
        {
            loadRecord();
            employer_txtbx1.ResetText();
        }

        private void employer_btn1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employer_cmbbx1.Text) || string.IsNullOrEmpty(employer_txtbx2.Text) || string.IsNullOrEmpty(employer_txtbx3.Text))
            {
                MessageBox.Show("Please input all the necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
            }
            else
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO `jobpost` (job_title, job_desc, contact_info) VALUES (@jobtitle, @jobdesc, @contactinfo)";
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@jobtitle", employer_cmbbx1.Text);
                    command.Parameters.AddWithValue("@jobdesc", employer_txtbx2.Text);
                    command.Parameters.AddWithValue("@contactinfo", employer_txtbx3.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Post added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecord();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add post", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error Code: " + ex.Number);
                    Console.WriteLine("Error Message: " + ex.Message);
                }
            }
        }


        private void loadRecord()
        {
            Employer_datagrdvw1.Rows.Clear();
            try
            {
                connection.Open();
                string selectQuery = "SELECT job_title, job_desc, contact_info FROM jobpost";
                command = new MySqlCommand(selectQuery, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employer_datagrdvw1.Rows.Add(Employer_datagrdvw1.Rows.Count + 1, reader["job_title"].ToString(), reader["job_desc"].ToString(), reader["contact_info"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void employer_btn2_Click(object sender, EventArgs e)
        {
            // Update button functionality
            if (string.IsNullOrEmpty(employer_txtbx1.Text) || string.IsNullOrEmpty(employer_cmbbx1.Text) || string.IsNullOrEmpty(employer_txtbx2.Text) || string.IsNullOrEmpty(employer_txtbx3.Text))
            {
                MessageBox.Show("Please input all the necessary information", "Error");
                clearFields();
            }
            else
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE jobpost SET job_title=@jobtitle, job_desc=@jobdesc, contact_info=@contactinfo WHERE id=@id";
                    command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(employer_txtbx1.Text)); // Use the ID for the update
                    command.Parameters.AddWithValue("@jobtitle", employer_cmbbx1.Text);
                    command.Parameters.AddWithValue("@jobdesc", employer_txtbx2.Text);
                    command.Parameters.AddWithValue("@contactinfo", employer_txtbx3.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                        loadRecord();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Make sure the ID exists in the database.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }
        }


        private void employer_btn3_Click(object sender, EventArgs e)
{
    // Delete button functionality
    if (string.IsNullOrEmpty(employer_txtbx1.Text))
    {
        MessageBox.Show("Please input the ID to delete the record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        clearFields();
    }
    else
    {
        try
        {
            // Validate the input to ensure it's a valid integer
            if (int.TryParse(employer_txtbx1.Text, out int id))
            {
                connection.Open();

                // Update the query to delete based on 'id'
                string deleteQuery = "DELETE FROM jobpost WHERE id = @id";
                command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRecord();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("No records were deleted. Make sure the ID exists in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



        private void clearFields()
        {
            employer_txtbx1.Clear();
            employer_cmbbx1.SelectedIndex = -1; // Clear the ComboBox selection
            employer_txtbx2.Clear();
            employer_txtbx3.Clear();
        }



        private void employer_cmbbx1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void employer_txtbx4_TextChanged(object sender, EventArgs e)
        {
            Employer_datagrdvw1.Rows.Clear();
            connection.Open();
            command = new MySqlCommand("SELECT job_title, job_desc, contact_info FROM jobpost WHERE job_title LIKE @searchText", connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@searchText", "%" + employer_txtbx4.Text + "%");
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employer_datagrdvw1.Rows.Add(Employer_datagrdvw1.Rows.Count + 1,
                    reader["job_title"].ToString(),
                    reader["job_desc"].ToString(),
                    reader["contact_info"].ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(employer_txtbx1.Text))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT id, job_title, job_desc, contact_info FROM jobpost WHERE id=@id";
                    command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(employer_txtbx1.Text));
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        employer_txtbx1.Text = reader["id"].ToString();
                        employer_cmbbx1.Text = reader["job_title"].ToString();
                        employer_txtbx2.Text = reader["job_desc"].ToString();
                        employer_txtbx3.Text = reader["contact_info"].ToString();
                    }
                    else
                    {
                       
                        employer_txtbx1.Text = "";
                        employer_cmbbx1.Text = "";
                        employer_txtbx2.Text = "";
                        employer_txtbx3.Text = "";
                        MessageBox.Show("No record found for the given ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Employer_datagrdvw1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            employer_cmbbx1.Text = Employer_datagrdvw1.CurrentRow.Cells[1].Value.ToString();
            employer_txtbx2.Text = Employer_datagrdvw1.CurrentRow.Cells[2].Value.ToString();
            employer_txtbx3.Text = Employer_datagrdvw1.CurrentRow.Cells[3].Value.ToString();
        }

        private void employer_lbl2_Click(object sender, EventArgs e)
        {

        }

        private void employer_txtbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void employer_txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void employer_lbl3_Click(object sender, EventArgs e)
        {

        }
    }
}