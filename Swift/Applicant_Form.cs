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

namespace Swift
{
    public partial class Applicant_Form : Form
    {
        public Applicant_Form()
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

            applicant_pnl3.BackgroundImage = new Bitmap(applicant_pnl3.Width, applicant_pnl3.Height);
            Graphics graphics2 = Graphics.FromImage(applicant_pnl3.BackgroundImage);
            graphics2.FillRectangle(gradientBrush, applicant_pnl3.ClientRectangle);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Applicant_Form_Load(object sender, EventArgs e)
        {

        }

        private void Applicant_lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Applicant_pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Applicant_btn3_Click(object sender, EventArgs e)
        {
            Opening_form Backhome3 = new Opening_form();
            Backhome3.Show();
            this.Hide();
        }
    }
    }

