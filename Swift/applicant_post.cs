using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Swift
{
    public partial class applicant_post : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlCommand command;
        MySqlDataReader reader;

        public applicant_post()
        {
            InitializeComponent();
            
            LoadData();
        }

        private void LoadData()
        {
            Applicant_Datagrdvw1.Rows.Clear();
            try
            {
                connection.Open();
                string selectQuery = "SELECT job_title, job_desc, contact_info FROM jobpost";
                command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Applicant_Datagrdvw1.Rows.Add(Applicant_Datagrdvw1.Rows.Count + 1, reader["job_title"].ToString(), reader["job_desc"].ToString(), reader["contact_info" +
                        ""].ToString());
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

        private void clearFields()
        {
            applicant_txtbx1.Clear();
            applicant_txtbx2.Clear();
            applicant_txtbx3.Clear();
        }

       

        private void applicant_post_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Applicant_Datagrdvw1.CurrentRow.Cells[1].Value.ToString();
            Applicant_Datagrdvw1.CurrentRow.Cells[2].Value.ToString();
            Applicant_Datagrdvw1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(applicant_txtbx3.Text) || string.IsNullOrEmpty(applicant_txtbx4.Text) || string.IsNullOrEmpty(applicant_rtxtbx1.Text)
                || string.IsNullOrEmpty(applicant_txtbx5.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error");
            }
            else
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO `job_inquiries`(`job_title`, `fullname`, `contact_info`,`CV_resume`) VALUES (@JobTitle, @FullName,@ContactInfo,@CVResume)";
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@JobTitle", applicant_txtbx3.Text);
                    command.Parameters.AddWithValue("@FullName", applicant_txtbx4.Text);
                    command.Parameters.AddWithValue("@ContactInfo", applicant_txtbx5.Text);
                    command.Parameters.AddWithValue("@CVResume", applicant_rtxtbx1.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Application Sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                Applicant_Datagrdvw1.Rows.Clear();
                connection.Open();
                command = new MySqlCommand("SELECT job_title,job_desc, contact_info FROM jobpost WHERE job_title LIKE @searchText ", connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@searchText", "%" + applicant_txtbx1.Text + "%");
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Applicant_Datagrdvw1.Rows.Add(Applicant_Datagrdvw1.Rows.Count + 1, 
                        reader["job_title"].ToString(),
                        reader["job_desc"].ToString(), 
                        reader["contact_info"].ToString());
                }
                reader.Close();
                connection.Close();
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(applicant_txtbx2.Text))
            {
                try
                {
                    connection.Open();
                    string searchText = "%" + applicant_txtbx2.Text + "%";
                    string selectQuery = "SELECT id, job_title, job_desc, contact_info FROM jobpost WHERE id LIKE @searchText";
                    command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@searchText", searchText);
                    reader = command.ExecuteReader();

                    // Clear the DataGridView before adding new rows
                    Applicant_Datagrdvw1.Rows.Clear();

                    while (reader.Read())
                    {
                        // Add data to the DataGridView
                        Applicant_Datagrdvw1.Rows.Add(
                            Applicant_Datagrdvw1.Rows.Count + 1,
                           
                            reader["job_title"].ToString(),
                            reader["job_desc"].ToString(),
                            reader["contact_info"].ToString(),
                            // Add empty strings for job_desc and contact_info columns
                            "", "","",""
                        );

                        // Populate applicant_txtbx3 with the job title
                        applicant_txtbx3.Text = reader["job_title"].ToString();
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
            else
            {
                // Clear the DataGridView when the textbox is empty
                Applicant_Datagrdvw1.Rows.Clear();

                // Clear other textboxes
                applicant_txtbx3.Clear();
            }
        }

        private void applicant_btn2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void applicant_txtbx3_TextChanged(object sender, EventArgs e)
        {

        }


        private void Applicant_btn3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;

            // Check if a file was selected
            if (!string.IsNullOrEmpty(filename))
            {
                try
                {
                    // Explicitly close the file dialog
                    openFileDialog1.Dispose();

                    // Read the contents of the selected file
                    string fileContent = File.ReadAllText(filename);

                    // Load the file content into the richtextbox
                    applicant_rtxtbx1.Text = fileContent;

                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applicant_txtbx5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
