using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movement
{
    public partial class Form1 : Form
    {
        private int startPos = 3, endPos = 343;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            pictureBox.Left = startPos;
            StartButton.Enabled = false;
            MoveTimer.Enabled = true;
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Location.X < endPos)
            {
                pictureBox.Left += 3;
                pictureBox.BackColor = RandRGBColor();
            }
            else
            {
                pictureBox.Left = endPos;
                MoveTimer.Stop();
                StartButton.Enabled = true;
            }
        }

        private Color RandRGBColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
