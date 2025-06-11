using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AreaOutputTextBox.Text = Convert.ToString(Math.Round(2 * Math.PI * Convert.ToDouble(RadiusTextBox.Text), 4));
        }

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            int diameter = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(RadiusTextBox.Text) * 2));

            Pen pen = new Pen(Color.Black, 10);
            Rectangle circle = new Rectangle(Convert.ToInt32(CordXTextBox.Text), Convert.ToInt32(CordYTextBox.Text), diameter, diameter);
            Graphics grafics = Graphics.FromHwnd(pictureBox1.Handle);

            grafics.DrawEllipse(pen, circle);
        }
    }
}
