using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Swift
{
    public partial class applicant_notif : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=SwiftHire");

        public applicant_notif()
        {
            InitializeComponent();
            SetBackground();
            LoadData();
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
            if (Applicant_Datagrdvw1 == null)
            {
                MessageBox.Show("Applicant_Datagrdvw1 is not initialized.");
                return;
            }

            Applicant_Datagrdvw1.Rows.Clear();
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

                            Applicant_Datagrdvw1.Rows.Add(Applicant_Datagrdvw1.Rows.Count + 1, jobTitle, fullName, contactInfo, cvResume);
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

        private void applicant_notif_Load(object sender, EventArgs e)
        {
            // Event handler for form load
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Applicant_Datagrdvw1.CurrentRow != null)
            {
                Applicant_Datagrdvw1.CurrentRow.Cells[1].Value.ToString();
                Applicant_Datagrdvw1.CurrentRow.Cells[2].Value.ToString();
                Applicant_Datagrdvw1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
