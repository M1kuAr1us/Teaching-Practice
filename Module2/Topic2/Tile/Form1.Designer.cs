namespace Tile
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
            this.StartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalcButton = new System.Windows.Forms.Button();
            this.WallAreaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TileHeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TileWidthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TileCountText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TileBoxCountText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(261, 378);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 60);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "почати розрахунок";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalcButton);
            this.panel1.Controls.Add(this.WallAreaTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TileHeightTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TileWidthTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 141);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CalcButton.Location = new System.Drawing.Point(341, 108);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(100, 30);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Розрахувати";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // WallAreaTextBox
            // 
            this.WallAreaTextBox.Location = new System.Drawing.Point(662, 47);
            this.WallAreaTextBox.Name = "WallAreaTextBox";
            this.WallAreaTextBox.Size = new System.Drawing.Size(50, 20);
            this.WallAreaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(562, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Площа стіни (м^2):";
            // 
            // TileHeightTextBox
            // 
            this.TileHeightTextBox.Location = new System.Drawing.Point(407, 47);
            this.TileHeightTextBox.Name = "TileHeightTextBox";
            this.TileHeightTextBox.Size = new System.Drawing.Size(50, 20);
            this.TileHeightTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(262, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Висота плитки (см):";
            // 
            // TileWidthTextBox
            // 
            this.TileWidthTextBox.Location = new System.Drawing.Point(156, 47);
            this.TileWidthTextBox.Name = "TileWidthTextBox";
            this.TileWidthTextBox.Size = new System.Drawing.Size(50, 20);
            this.TileWidthTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина плитки (см):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TileCountText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TileBoxCountText);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 141);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // TileCountText
            // 
            this.TileCountText.AutoSize = true;
            this.TileCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TileCountText.Location = new System.Drawing.Point(530, 57);
            this.TileCountText.Name = "TileCountText";
            this.TileCountText.Size = new System.Drawing.Size(16, 17);
            this.TileCountText.TabIndex = 3;
            this.TileCountText.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(404, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Кількість плиток:";
            // 
            // TileBoxCountText
            // 
            this.TileBoxCountText.AutoSize = true;
            this.TileBoxCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TileBoxCountText.Location = new System.Drawing.Point(348, 57);
            this.TileBoxCountText.Name = "TileBoxCountText";
            this.TileBoxCountText.Size = new System.Drawing.Size(16, 17);
            this.TileBoxCountText.TabIndex = 1;
            this.TileBoxCountText.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(111, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Кількість коробок з плиткою (шт):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плитка (Завалій Іван)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TileHeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TileWidthTextBox;
        private System.Windows.Forms.TextBox WallAreaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TileBoxCountText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TileCountText;
    }
}

