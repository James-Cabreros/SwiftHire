using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            SetBackground();
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
                    Applicant_Datagrdvw1.Rows.Add(Applicant_Datagrdvw1.Rows.Count + 1, reader["job_title"].ToString(), reader["job_desc"].ToString(), reader["contact_info"].ToString());
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
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                Applicant_Datagrdvw1.Rows.Clear();
                connection.Open();
                command = new MySqlCommand("SELECT job_title, job_desc, contact_info FROM jobpost WHERE job_title LIKE @searchText OR job_desc LIKE @searchText OR contact_info LIKE @searchText", connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@searchText", "%" + applicant_txtbx1.Text + "%");
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Applicant_Datagrdvw1.Rows.Add(Applicant_Datagrdvw1.Rows.Count + 1, reader["job_title"].ToString(), reader["job_desc"].ToString(), reader["contact_info"].ToString());
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}
