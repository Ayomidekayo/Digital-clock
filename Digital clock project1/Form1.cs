using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_clock_project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            redButton1.FlatStyle = FlatStyle.Flat;
            OrangeButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {

        }

        private void redButton1_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Red;
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Orange;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Yellow;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Green;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            ClockLabel.ForeColor = Color.Blue;
        }

        private void styleButton_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Impact", 95, FontStyle.Regular);
        }

        private void StyleButton2_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Consolas", 95, FontStyle.Regular);
        }

        private void StyleButton3_Click(object sender, EventArgs e)
        {
            ClockLabel.Font = new Font("Century", 95, FontStyle.Regular);
        }
    }
}
