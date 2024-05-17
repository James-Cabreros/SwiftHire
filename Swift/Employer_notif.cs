using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swift
{
    public partial class Employer_notif : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");
        MySqlDataReader reader;
        public Employer_notif()
        {
            InitializeComponent(); 
            SetBackground();
            LoadData();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            // Assuming these are the job titles
            string[] Status = { "Accept", "Will Contact", "Decline" };
            employer_cmbbx1.Items.AddRange(Status);
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

        private void LoadData()
        {
            if (employer_datagrdvw1 == null)
            {
                MessageBox.Show("Applicant_Datagrdvw1 is not initialized.");
                return;
            }

            employer_datagrdvw1.Rows.Clear();
            try
            {
                connection.Open();
                string selectQuery = "SELECT id, job_title, fullname, contact_info, CV_resume FROM job_inquiries";

                using (var command = new MySqlCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string jobTitle = reader["job_title"].ToString();
                            string fullName = reader["fullname"].ToString();
                            string contactInfo = reader["contact_info"].ToString();
                            string cvResume = reader["CV_resume"].ToString(); // Retrieve CV_resume column

                            employer_datagrdvw1.Rows.Add(employer_datagrdvw1.Rows.Count + 1, jobTitle, fullName, contactInfo, cvResume);
                        }
                    }
                }
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
        private void Employer_notif_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employer_datagrdvw1.CurrentRow != null)
            {
                employer_datagrdvw1.CurrentRow.Cells[1].Value.ToString();
                employer_datagrdvw1.CurrentRow.Cells[2].Value.ToString();
                employer_datagrdvw1.CurrentRow.Cells[3].Value.ToString();
            }
        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(employer_txtbx1.Text))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT id, job_title, fullname, contact_info, CV_resume FROM job_inquiries WHERE id=@id LIKE @searchtext";
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(employer_txtbx1.Text));
                    MySqlDataReader reader = command.ExecuteReader();

                    employer_datagrdvw1.Rows.Clear();

                    if (reader.Read())
                    {
                        employer_txtbx1.Text = reader["id"].ToString();
                        employer_txtbx2.Text = reader["job_title"].ToString();
                        employer_txtbx3.Text = reader["fullname"].ToString();
                        employer_txtbx4.Text = reader["contact_info"].ToString();

                        byte[] cvData = (byte[])reader["CV_resume"]; // Fetch the binary data
                        string cvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CV_resume.pdf"); // Save to Desktop
                        File.WriteAllBytes(cvFilePath, cvData);

                        employer_txtbx5.Text = cvFilePath; // Display the file path in the TextBox (or use a Label)
                    }
                    else
                    {
                        // Clear all TextBoxes if no record found for the given ID
                        employer_txtbx1.Text = "";
                        employer_txtbx2.Text = "";
                        employer_txtbx3.Text = "";
                        employer_txtbx4.Text = "";
                        employer_txtbx5.Text = "";
                    }

                    reader.Close();
                    connection.Close();
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(employer_txtbx5.Text) && File.Exists(employer_txtbx5.Text))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = employer_txtbx5.Text,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("The CV file does not exist.");
            }
        }

        private void employer_txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void employer_txtbx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void employer_txtbx5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
