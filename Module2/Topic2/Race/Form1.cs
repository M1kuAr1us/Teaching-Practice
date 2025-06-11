using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        private const int StartX = 101;
        private const int FinishX = 692;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTimer.Start();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CockroachA.Left = StartX;
            CockroachB.Left = StartX;
            CockroachC.Left = StartX;

            ResultTextBox.Clear();

            StartButton.Visible = true;
            ResetButton.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            if (CockroachA.Left < FinishX && CockroachB.Left < FinishX && CockroachC.Left < FinishX)
            {
                CockroachA.Left += random.Next(20);
                CockroachB.Left += random.Next(20);
                CockroachC.Left += random.Next(20);
            }
            else
            {
                StartTimer.Stop();

                if (CockroachA.Left >= FinishX) ResultTextBox.Text = "Тарган A";
                else if (CockroachB.Left >= FinishX) ResultTextBox.Text = "Тарган B";
                else if (CockroachC.Left >= FinishX) ResultTextBox.Text = "Тарган C";

                StartButton.Visible = false;
                ResetButton.Visible = true;
            }
        }
    }
}
