using System.Drawing;
using System.Windows.Forms;

namespace Race
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CockroachA = new System.Windows.Forms.PictureBox();
            this.CockroachB = new System.Windows.Forms.PictureBox();
            this.CockroachC = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox1.Location = new System.Drawing.Point(101, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox2.Location = new System.Drawing.Point(101, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(625, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox3.Location = new System.Drawing.Point(101, 219);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(625, 35);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // CockroachA
            // 
            this.CockroachA.BackColor = System.Drawing.Color.Red;
            this.CockroachA.Image = ((System.Drawing.Image)(resources.GetObject("CockroachA.Image")));
            this.CockroachA.Location = new System.Drawing.Point(101, 116);
            this.CockroachA.Name = "CockroachA";
            this.CockroachA.Size = new System.Drawing.Size(34, 35);
            this.CockroachA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CockroachA.TabIndex = 3;
            this.CockroachA.TabStop = false;
            // 
            // CockroachB
            // 
            this.CockroachB.BackColor = System.Drawing.Color.Green;
            this.CockroachB.Image = ((System.Drawing.Image)(resources.GetObject("CockroachB.Image")));
            this.CockroachB.Location = new System.Drawing.Point(101, 168);
            this.CockroachB.Name = "CockroachB";
            this.CockroachB.Size = new System.Drawing.Size(34, 35);
            this.CockroachB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CockroachB.TabIndex = 4;
            this.CockroachB.TabStop = false;
            // 
            // CockroachC
            // 
            this.CockroachC.BackColor = System.Drawing.Color.Blue;
            this.CockroachC.Image = ((System.Drawing.Image)(resources.GetObject("CockroachC.Image")));
            this.CockroachC.Location = new System.Drawing.Point(101, 219);
            this.CockroachC.Name = "CockroachC";
            this.CockroachC.Size = new System.Drawing.Size(34, 35);
            this.CockroachC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CockroachC.TabIndex = 5;
            this.CockroachC.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StartButton.ForeColor = System.Drawing.Color.Chocolate;
            this.StartButton.Location = new System.Drawing.Point(171, 291);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(76, 40);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Пуск";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResetButton.ForeColor = System.Drawing.Color.Blue;
            this.ResetButton.Location = new System.Drawing.Point(584, 291);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(107, 40);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Ще разок!";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(246, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Переможець";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ResultTextBox.Location = new System.Drawing.Point(387, 367);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(235, 29);
            this.ResultTextBox.TabIndex = 11;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ExitButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.ExitButton.Location = new System.Drawing.Point(757, 398);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 40);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 50;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Violet;
            this.textBox2.Location = new System.Drawing.Point(287, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(283, 40);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Іподром";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(723, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 40);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Фініш";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Red;
            this.textBox4.Location = new System.Drawing.Point(10, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(92, 40);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Старт";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CockroachC);
            this.Controls.Add(this.CockroachB);
            this.Controls.Add(this.CockroachA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегони (Завалій Іван)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CockroachC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox CockroachA;
        private System.Windows.Forms.PictureBox CockroachB;
        private System.Windows.Forms.PictureBox CockroachC;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer StartTimer;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}

