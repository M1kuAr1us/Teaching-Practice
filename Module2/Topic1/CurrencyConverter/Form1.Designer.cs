
namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PoundRadioButton = new System.Windows.Forms.RadioButton();
            this.EuroRadioButton = new System.Windows.Forms.RadioButton();
            this.DollarRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBPCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EURCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.USDCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertCurrencyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ConvertedText = new System.Windows.Forms.Label();
            this.CheckIssuingCheckBox = new System.Windows.Forms.CheckBox();
            this.CurrencyPictureBox = new System.Windows.Forms.PictureBox();
            this.ReceiptPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Гривні:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(72, 15);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 23);
            this.InputTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PoundRadioButton);
            this.groupBox1.Controls.Add(this.EuroRadioButton);
            this.groupBox1.Controls.Add(this.DollarRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(15, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть валюту";
            // 
            // PoundRadioButton
            // 
            this.PoundRadioButton.AutoSize = true;
            this.PoundRadioButton.Location = new System.Drawing.Point(6, 76);
            this.PoundRadioButton.Name = "PoundRadioButton";
            this.PoundRadioButton.Size = new System.Drawing.Size(102, 21);
            this.PoundRadioButton.TabIndex = 2;
            this.PoundRadioButton.Text = "фунт (GBP)";
            this.PoundRadioButton.UseVisualStyleBackColor = true;
            this.PoundRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // EuroRadioButton
            // 
            this.EuroRadioButton.AutoSize = true;
            this.EuroRadioButton.Checked = true;
            this.EuroRadioButton.Location = new System.Drawing.Point(6, 49);
            this.EuroRadioButton.Name = "EuroRadioButton";
            this.EuroRadioButton.Size = new System.Drawing.Size(99, 21);
            this.EuroRadioButton.TabIndex = 1;
            this.EuroRadioButton.TabStop = true;
            this.EuroRadioButton.Text = "євро (EUR)";
            this.EuroRadioButton.UseVisualStyleBackColor = true;
            this.EuroRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // DollarRadioButton
            // 
            this.DollarRadioButton.AutoSize = true;
            this.DollarRadioButton.Location = new System.Drawing.Point(6, 22);
            this.DollarRadioButton.Name = "DollarRadioButton";
            this.DollarRadioButton.Size = new System.Drawing.Size(109, 21);
            this.DollarRadioButton.TabIndex = 0;
            this.DollarRadioButton.Text = "долар (USD)";
            this.DollarRadioButton.UseVisualStyleBackColor = true;
            this.DollarRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GBPCurrencyTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EURCurrencyTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.USDCurrencyTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(21, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Курси валют";
            // 
            // GBPCurrencyTextBox
            // 
            this.GBPCurrencyTextBox.Location = new System.Drawing.Point(251, 27);
            this.GBPCurrencyTextBox.Name = "GBPCurrencyTextBox";
            this.GBPCurrencyTextBox.Size = new System.Drawing.Size(52, 23);
            this.GBPCurrencyTextBox.TabIndex = 5;
            this.GBPCurrencyTextBox.Text = "36.06";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "GBP";
            // 
            // EURCurrencyTextBox
            // 
            this.EURCurrencyTextBox.Location = new System.Drawing.Point(150, 27);
            this.EURCurrencyTextBox.Name = "EURCurrencyTextBox";
            this.EURCurrencyTextBox.Size = new System.Drawing.Size(52, 23);
            this.EURCurrencyTextBox.TabIndex = 3;
            this.EURCurrencyTextBox.Text = "32.88";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "EUR";
            // 
            // USDCurrencyTextBox
            // 
            this.USDCurrencyTextBox.Location = new System.Drawing.Point(49, 27);
            this.USDCurrencyTextBox.Name = "USDCurrencyTextBox";
            this.USDCurrencyTextBox.Size = new System.Drawing.Size(52, 23);
            this.USDCurrencyTextBox.TabIndex = 1;
            this.USDCurrencyTextBox.Text = "26.43";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "USD";
            // 
            // ConvertCurrencyButton
            // 
            this.ConvertCurrencyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ConvertCurrencyButton.Location = new System.Drawing.Point(210, 12);
            this.ConvertCurrencyButton.Name = "ConvertCurrencyButton";
            this.ConvertCurrencyButton.Size = new System.Drawing.Size(150, 50);
            this.ConvertCurrencyButton.TabIndex = 4;
            this.ConvertCurrencyButton.Text = "Конвертувати";
            this.ConvertCurrencyButton.UseVisualStyleBackColor = true;
            this.ConvertCurrencyButton.Click += new System.EventHandler(this.ConvertCurrencyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(382, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "До видачі:";
            // 
            // ConvertedText
            // 
            this.ConvertedText.AutoSize = true;
            this.ConvertedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ConvertedText.Location = new System.Drawing.Point(501, 24);
            this.ConvertedText.Name = "ConvertedText";
            this.ConvertedText.Size = new System.Drawing.Size(21, 24);
            this.ConvertedText.TabIndex = 6;
            this.ConvertedText.Text = "0";
            // 
            // CheckIssuingCheckBox
            // 
            this.CheckIssuingCheckBox.AutoSize = true;
            this.CheckIssuingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CheckIssuingCheckBox.Location = new System.Drawing.Point(686, 28);
            this.CheckIssuingCheckBox.Name = "CheckIssuingCheckBox";
            this.CheckIssuingCheckBox.Size = new System.Drawing.Size(102, 21);
            this.CheckIssuingCheckBox.TabIndex = 7;
            this.CheckIssuingCheckBox.Text = "Видати чек";
            this.CheckIssuingCheckBox.UseVisualStyleBackColor = true;
            // 
            // CurrencyPictureBox
            // 
            this.CurrencyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyPictureBox.Image")));
            this.CurrencyPictureBox.Location = new System.Drawing.Point(178, 83);
            this.CurrencyPictureBox.Name = "CurrencyPictureBox";
            this.CurrencyPictureBox.Size = new System.Drawing.Size(398, 210);
            this.CurrencyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrencyPictureBox.TabIndex = 8;
            this.CurrencyPictureBox.TabStop = false;
            // 
            // ReceiptPictureBox
            // 
            this.ReceiptPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ReceiptPictureBox.Image")));
            this.ReceiptPictureBox.Location = new System.Drawing.Point(594, 73);
            this.ReceiptPictureBox.Name = "ReceiptPictureBox";
            this.ReceiptPictureBox.Size = new System.Drawing.Size(194, 268);
            this.ReceiptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReceiptPictureBox.TabIndex = 9;
            this.ReceiptPictureBox.TabStop = false;
            this.ReceiptPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiptPictureBox);
            this.Controls.Add(this.CurrencyPictureBox);
            this.Controls.Add(this.CheckIssuingCheckBox);
            this.Controls.Add(this.ConvertedText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConvertCurrencyButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Конвертор валют (Завалій Іван)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PoundRadioButton;
        private System.Windows.Forms.RadioButton EuroRadioButton;
        private System.Windows.Forms.RadioButton DollarRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GBPCurrencyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EURCurrencyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USDCurrencyTextBox;
        private System.Windows.Forms.Button ConvertCurrencyButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ConvertedText;
        private System.Windows.Forms.CheckBox CheckIssuingCheckBox;
        private System.Windows.Forms.PictureBox CurrencyPictureBox;
        private System.Windows.Forms.PictureBox ReceiptPictureBox;
    }
}

