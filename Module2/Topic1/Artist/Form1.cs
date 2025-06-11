using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RadioChecked = sender as RadioButton;

            if (RadioChecked.Name == SunflowersRadioButton.Name)
            {
                pictureBox2.Image = Image.FromFile("Соняшники.jpg");
            }
            else if (RadioChecked.Name == IrisesRadioButton.Name)
            {
                pictureBox2.Image = Image.FromFile("Іриси.jpg");
            }
            else if (RadioChecked.Name == StarryNightRadioButton.Name)
            {
                pictureBox2.Image = Image.FromFile("ЗорянаНіч.jpg");
            }
            else if (RadioChecked.Name == TerraceRadioButton.Name)
            {
                pictureBox2.Image = Image.FromFile("ТерасаКафеВНочі.jpg");
            }
        }
    }
}
