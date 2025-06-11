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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AmoebaFormButton_Click(object sender, EventArgs e)
        {
            AmoebaForm amoebaForm = new AmoebaForm();
            amoebaForm.Show();
        }

        private void HouseFormButton_Click(object sender, EventArgs e)
        {
            HouseForm houseForm = new HouseForm();
            houseForm.Show();
        }
    }
}
