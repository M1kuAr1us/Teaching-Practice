using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequencesSum
{
    public partial class Form1 : Form
    {
        private int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(InputNumericUpDown.Value);

            if (Condition1CheckBox.Checked) Condition1Calculate();
            if (Condition2CheckBox.Checked) Condition2Calculate();
            if (Condition3CheckBox.Checked) Condition3Calculate();
        }

        private void Condition1Calculate()
        {
            int result = 0;

            for (int i = 1; i <= num; i++) result += i;

            Condition1ResultTextBox.Text = result.ToString();
        }

        private void Condition2Calculate()
        {
            int result = 0;

            for (int i = 1; i <= num; i++) result += i + 2;

            Condition2ResultTextBox.Text = result.ToString();
        }

        private void Condition3Calculate()
        {
            double result = 0;

            for (double i = 1; i <= num; i++) result += 1 / i;

            Condition3ResultTextBox.Text = Convert.ToString(Math.Round(result, 4));
        }
    }
}
