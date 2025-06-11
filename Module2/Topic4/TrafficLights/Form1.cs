using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TrafficLightsButton_Click(object sender, EventArgs e)
        {
            Button ButtonClicked = sender as Button;

            if (ButtonClicked.Name == TrafficLightsButton.Name)
            {
                panel1.Visible = true;
                Light1.Image = Properties.Resources.gray;
                Light2.Image = Properties.Resources.gray;
                Light3.Image = Properties.Resources.gray;
            }
            else if (ButtonClicked.Name == StopLightButton.Name)
            {
                Light1.Image = Properties.Resources.red;
                Light2.Image = Properties.Resources.gray;
                Light3.Image = Properties.Resources.gray;
            }
            else if (ButtonClicked.Name == ReadyLightButton.Name)
            {
                Light1.Image = Properties.Resources.gray;
                Light2.Image = Properties.Resources.yellow;
                Light3.Image = Properties.Resources.gray;
            }
            else if (ButtonClicked.Name == GoLightButton.Name)
            {
                Light1.Image = Properties.Resources.gray;
                Light2.Image = Properties.Resources.gray;
                Light3.Image = Properties.Resources.green;
            }
        }
    }
}
