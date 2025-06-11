using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private string currency = "USD";
        private double converted;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton CheckedRadioButton = sender as RadioButton;

            if (CheckedRadioButton.Name == DollarRadioButton.Name)
            {
                currency = "USD";
                CurrencyPictureBox.Image = Image.FromFile("Dollar.png");
            }
            else if (CheckedRadioButton.Name == EuroRadioButton.Name)
            {
                currency = "EUR";
                CurrencyPictureBox.Image = Image.FromFile("Euro.jpg");
            }

            else if (CheckedRadioButton.Name == PoundRadioButton.Name)
            {
                currency = "GBP";
                CurrencyPictureBox.Image = Image.FromFile("Pound.png");
            }
        }

        private void ConvertCurrencyButton_Click(object sender, EventArgs e)
        {
            switch (currency)
            {
                case "USD":
                    converted = Math.Round(Convert.ToDouble(InputTextBox.Text) / Convert.ToDouble(USDCurrencyTextBox.Text), 2);
                    break;
                case "EUR":
                    converted = Math.Round(Convert.ToDouble(InputTextBox.Text) / Convert.ToDouble(EURCurrencyTextBox.Text), 2);
                    break;
                case "GBP":
                    converted = Math.Round(Convert.ToDouble(InputTextBox.Text) / Convert.ToDouble(GBPCurrencyTextBox.Text), 2);
                    break;
            }

            if (CheckIssuingCheckBox.Checked)
                ReceiptPictureBox.Visible = true;
            else
                ReceiptPictureBox.Visible = false;

            ConvertedText.Text = Convert.ToString($"{converted} {currency}");
        }
    }
}
