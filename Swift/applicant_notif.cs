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
        MySqlCommand command;
        MySqlDataReader reader;
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
            if (applicant_datagrdvw1 == null)
            {
                MessageBox.Show("Applicant_Datagrdvw1 is not initialized.");
                return;
            }

            applicant_datagrdvw1.Rows.Clear();
            try
            {
                connection.Open();
                string selectQuery = "SELECT id, job_title, fullname, Status FROM applicant_notif";

                using (var command = new MySqlCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string jobTitle = reader["job_title"].ToString();
                            string fullName = reader["fullname"].ToString();
                            string status = reader["Status"].ToString();
                            applicant_datagrdvw1.Rows.Add(applicant_datagrdvw1.Rows.Count + 1, jobTitle, fullName, status);
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
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (applicant_datagrdvw1.CurrentRow != null)
            {
                applicant_datagrdvw1.CurrentRow.Cells[1].Value.ToString();
                applicant_datagrdvw1.CurrentRow.Cells[2].Value.ToString();
                applicant_datagrdvw1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                applicant_datagrdvw1.Rows.Clear();
                connection.Open();
                command = new MySqlCommand("SELECT job_title, fullname, Status FROM applicant_notif WHERE job_title LIKE @searchText OR fullname LIKE @searchText OR Status LIKE @searchText", connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@searchText", "%" + applicant_txtbx1.Text + "%");
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    applicant_datagrdvw1.Rows.Add(applicant_datagrdvw1.Rows.Count + 1, 
                   reader["job_title"].ToString(), 
                   reader["fullname"].ToString(),
                   reader["Status"].ToString());
                }
                reader.Close();
                connection.Close();
            }
        }
       
    }
}
