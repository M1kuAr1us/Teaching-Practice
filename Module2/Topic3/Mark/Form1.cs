using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mark
{
    public partial class Form1 : Form
    {
        Pupil p = new Pupil();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(p.Sbal());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            p.name = textBox1.Text;
            p.priz = textBox2.Text;
            p.klass = int.Parse(numericUpDown1.Text);
            for (int i = 0; i < 10; i++)
            {
                int m = Convert.ToInt32(dataGridView1[i, 0].Value);
                p.makes[i] = m;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            bool slovo = p.Vidm();
            if (slovo == true)
                label8.Text = "yes";
            else
                label8.Text = "no";
        }
    }
    class Pupil
    {
        public string name, priz;
        public int klass;
        public int[] makes = new int[10];
        public double Sbal()
        {
            double s = 0;
            for (int i = 0; i < 10; i++)
            {
                s = s + makes[i];
            }
            s = s / 10;
            return s;
        }
        public bool Vidm()
        {
            for (int i = 0; i < 10; i++)
            {
                if (makes[i] < 10)
                    return false;
            }
            return true;
        }
    }
}
