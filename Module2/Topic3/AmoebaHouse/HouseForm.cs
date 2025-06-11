using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoebaHouse
{
    public partial class HouseForm : Form
    {
        public HouseForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double houseHight = Convert.ToDouble(HouseHightTextBox.Text);
            double blockHight = Convert.ToDouble(BlockHightTextBox.Text) / 100;

            int layers = Convert.ToInt32(Math.Ceiling(houseHight / blockHight));
            int blockCount = 0;

            for (int i = 1, j = 1; i <= layers; i++, j+=2)
            {
                blockCount += j;
            }

            ResultTextBox.Text = Convert.ToString(blockCount);
        }
    }
}
