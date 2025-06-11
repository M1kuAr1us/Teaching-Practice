using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasTrees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            TreesListBox.Items.Clear();

            Random random = new Random();
            int cost = 0;

            int treesCount = Convert.ToInt32(CountTreesListBox.Text);

            TreesListBox.Items.Add(Convert.ToString(string.Format("{0, -8} {1, -20}", "Номер", "Висота ялники (см)")));
            int[] trees = new int[treesCount];
            for (int i = 1; i <= trees.Length; i++)
            {
                trees[i - 1] = random.Next(100, 200);
                TreesListBox.Items.Add(Convert.ToString(string.Format("{0, -8} {1, -20}", i, trees[i - 1])));

                if (trees[i - 1] <= 150) cost += 200;
                else cost += 300;
            }

            ResultCost.Text = Convert.ToString(cost);
        }
    }
}