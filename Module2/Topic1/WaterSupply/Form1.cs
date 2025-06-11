using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSupply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            const double cost = 21.04;

            int count = Convert.ToInt32(FinalIndicatorsTextBox.Text) - Convert.ToInt32(InitialIndixatorsTextBox.Text);
            ConsumedText.Text = Convert.ToString(count);
            PayableText.Text = Convert.ToString(cost * count);

        }
    }
}
