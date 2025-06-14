﻿namespace CircleArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrawCircleButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AreaOutputTextBox = new System.Windows.Forms.TextBox();
            this.CordYTextBox = new System.Windows.Forms.TextBox();
            this.CordXTextBox = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.DrawCircleButton);
            this.panel1.Controls.Add(this.CalculateButton);
            this.panel1.Controls.Add(this.AreaOutputTextBox);
            this.panel1.Controls.Add(this.CordYTextBox);
            this.panel1.Controls.Add(this.CordXTextBox);
            this.panel1.Controls.Add(this.RadiusTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(520, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 307);
            this.panel1.TabIndex = 0;
            // 
            // DrawCircleButton
            // 
            this.DrawCircleButton.Location = new System.Drawing.Point(87, 253);
            this.DrawCircleButton.Name = "DrawCircleButton";
            this.DrawCircleButton.Size = new System.Drawing.Size(85, 23);
            this.DrawCircleButton.TabIndex = 9;
            this.DrawCircleButton.Text = "накреслити";
            this.DrawCircleButton.UseVisualStyleBackColor = true;
            this.DrawCircleButton.Click += new System.EventHandler(this.DrawCircleButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(146, 181);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(85, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "розрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AreaOutputTextBox
            // 
            this.AreaOutputTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.AreaOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AreaOutputTextBox.Location = new System.Drawing.Point(146, 127);
            this.AreaOutputTextBox.Name = "AreaOutputTextBox";
            this.AreaOutputTextBox.ReadOnly = true;
            this.AreaOutputTextBox.Size = new System.Drawing.Size(100, 23);
            this.AreaOutputTextBox.TabIndex = 7;
            // 
            // CordYTextBox
            // 
            this.CordYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CordYTextBox.Location = new System.Drawing.Point(146, 83);
            this.CordYTextBox.Name = "CordYTextBox";
            this.CordYTextBox.Size = new System.Drawing.Size(100, 23);
            this.CordYTextBox.TabIndex = 6;
            // 
            // CordXTextBox
            // 
            this.CordXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CordXTextBox.Location = new System.Drawing.Point(146, 55);
            this.CordXTextBox.Name = "CordXTextBox";
            this.CordXTextBox.Size = new System.Drawing.Size(100, 23);
            this.CordXTextBox.TabIndex = 5;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.RadiusTextBox.Location = new System.Drawing.Point(146, 10);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 23);
            this.RadiusTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Площа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Координата Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координата X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радіус";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Площа кола (Завалій Іван)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AreaOutputTextBox;
        private System.Windows.Forms.TextBox CordYTextBox;
        private System.Windows.Forms.TextBox CordXTextBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawCircleButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

