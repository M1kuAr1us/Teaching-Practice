using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            const double tileAreaInBox = 1.6;

            double width = Convert.ToDouble(TileWidthTextBox.Text) / 100;
            double height = Convert.ToDouble(TileHeightTextBox.Text) / 100;
            double tileArea = width * height;

            double wallArea = Convert.ToDouble(WallAreaTextBox.Text);

            panel2.Visible = true;
            TileBoxCountText.Text = Convert.ToString(Math.Ceiling(wallArea / tileAreaInBox));
            TileCountText.Text = Convert.ToString(Math.Ceiling(wallArea / tileArea));
        }
    }
}
