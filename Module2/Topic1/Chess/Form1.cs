using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        private int[,] beatCombinations = new int[,]
        {
            {2, 1}, {2, -1}, {-2, 1}, {-2, -1},
            {1, 2}, {-1, 2}, {1, -2}, {-1, -2}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int startPointY = Convert.ToInt32(StartPointYDomainUpDown.Text);
            int startPointX = Convert.ToInt32(StartPointXDomainUpDown.Text);

            int targetPointY = Convert.ToInt32(TargetPointYDomainUpDown.Text);
            int targetPointX = Convert.ToInt32(TargetPointXDomainUpDown.Text);

            for (int i  = 0; i < 8; i++)
            {
                if (startPointX > 7 || startPointX < 0 || startPointY > 7 || startPointY < 0)
                {
                    ResultTextBox.Text = "Стартова клітинка за межами поля.";
                    break;
                }
                else if (targetPointX > 7 || targetPointX < 0 || targetPointY > 7 || targetPointY < 0)
                {
                    ResultTextBox.Text = "Цільова клітинка за межами поля.";
                    break;
                }

                if (startPointY + beatCombinations[i, 0] == targetPointY && startPointX + beatCombinations[i, 1] == targetPointX)
                {
                    ResultTextBox.Text = "Кінь загрожує цільовій клітинці.";
                    break;
                }
                else ResultTextBox.Text = "Кінь не загрожує цільовій клітинці.";
            }
        }
    }
}
