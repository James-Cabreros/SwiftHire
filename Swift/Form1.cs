
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;


namespace Swift
{
    public partial class Opening_form : Form
    {
        public Opening_form()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Applicant_regis applicant_regis = new Applicant_regis();
            applicant_regis.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            employer_regis employer_Regis = new employer_regis();
            employer_Regis.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
