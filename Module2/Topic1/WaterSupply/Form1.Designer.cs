
namespace WaterSupply
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
            this.InitialIndixatorsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalIndicatorsTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConsumedText = new System.Windows.Forms.Label();
            this.PayableText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Початкові показники:";
            // 
            // InitialIndixatorsTextBox
            // 
            this.InitialIndixatorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.InitialIndixatorsTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.InitialIndixatorsTextBox.Location = new System.Drawing.Point(282, 84);
            this.InitialIndixatorsTextBox.Name = "InitialIndixatorsTextBox";
            this.InitialIndixatorsTextBox.Size = new System.Drawing.Size(100, 29);
            this.InitialIndixatorsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(81, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кінцеві показники:";
            // 
            // FinalIndicatorsTextBox
            // 
            this.FinalIndicatorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FinalIndicatorsTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FinalIndicatorsTextBox.Location = new System.Drawing.Point(282, 163);
            this.FinalIndicatorsTextBox.Name = "FinalIndicatorsTextBox";
            this.FinalIndicatorsTextBox.Size = new System.Drawing.Size(100, 29);
            this.FinalIndicatorsTextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CalculateButton.Location = new System.Drawing.Point(58, 283);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(216, 69);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Обчислити";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(467, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Спожито:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(454, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "До сплати:";
            // 
            // ConsumedText
            // 
            this.ConsumedText.AutoSize = true;
            this.ConsumedText.BackColor = System.Drawing.SystemColors.Control;
            this.ConsumedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsumedText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConsumedText.Location = new System.Drawing.Point(577, 89);
            this.ConsumedText.Name = "ConsumedText";
            this.ConsumedText.Size = new System.Drawing.Size(21, 24);
            this.ConsumedText.TabIndex = 7;
            this.ConsumedText.Text = "0";
            // 
            // PayableText
            // 
            this.PayableText.AutoSize = true;
            this.PayableText.BackColor = System.Drawing.SystemColors.Control;
            this.PayableText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayableText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PayableText.Location = new System.Drawing.Point(577, 163);
            this.PayableText.Name = "PayableText";
            this.PayableText.Size = new System.Drawing.Size(21, 24);
            this.PayableText.TabIndex = 8;
            this.PayableText.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(500, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PayableText);
            this.Controls.Add(this.ConsumedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.FinalIndicatorsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InitialIndixatorsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Водопостачання (Завалій Іван)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InitialIndixatorsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FinalIndicatorsTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ConsumedText;
        private System.Windows.Forms.Label PayableText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

