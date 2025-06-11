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
    public partial class AmoebaForm : Form
    {
        public AmoebaForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();

            int hours = Convert.ToInt32(HoursNumericUpDown.Value);

            ResultListBox.Items.Add(string.Format("{0, -8} {1, -15}", "Час", "Кількість амеб"));
            for (int i = 3, count = 3; i <= hours; i += 3, count *= 3)
            {
                ResultListBox.Items.Add(string.Format("{0, -8} {1, -15}", i, count));
            }
        }
    }
}
