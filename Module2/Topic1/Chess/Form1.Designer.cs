namespace Chess
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartPointXDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.StartPointYDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TargetPointXDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TargetPointYDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ResultButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StartPointXDomainUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StartPointYDomainUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стартова клітинка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Горизонталь";
            // 
            // StartPointXDomainUpDown
            // 
            this.StartPointXDomainUpDown.Items.Add("7");
            this.StartPointXDomainUpDown.Items.Add("6");
            this.StartPointXDomainUpDown.Items.Add("5");
            this.StartPointXDomainUpDown.Items.Add("4");
            this.StartPointXDomainUpDown.Items.Add("3");
            this.StartPointXDomainUpDown.Items.Add("2");
            this.StartPointXDomainUpDown.Items.Add("1");
            this.StartPointXDomainUpDown.Items.Add("0");
            this.StartPointXDomainUpDown.Location = new System.Drawing.Point(83, 45);
            this.StartPointXDomainUpDown.Name = "StartPointXDomainUpDown";
            this.StartPointXDomainUpDown.Size = new System.Drawing.Size(35, 20);
            this.StartPointXDomainUpDown.TabIndex = 2;
            this.StartPointXDomainUpDown.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вертикаль";
            // 
            // StartPointYDomainUpDown
            // 
            this.StartPointYDomainUpDown.Items.Add("7");
            this.StartPointYDomainUpDown.Items.Add("6");
            this.StartPointYDomainUpDown.Items.Add("5");
            this.StartPointYDomainUpDown.Items.Add("4");
            this.StartPointYDomainUpDown.Items.Add("3");
            this.StartPointYDomainUpDown.Items.Add("2");
            this.StartPointYDomainUpDown.Items.Add("1");
            this.StartPointYDomainUpDown.Items.Add("0");
            this.StartPointYDomainUpDown.Location = new System.Drawing.Point(83, 19);
            this.StartPointYDomainUpDown.Name = "StartPointYDomainUpDown";
            this.StartPointYDomainUpDown.Size = new System.Drawing.Size(35, 20);
            this.StartPointYDomainUpDown.TabIndex = 0;
            this.StartPointYDomainUpDown.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TargetPointXDomainUpDown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TargetPointYDomainUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цільова клітинка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Горизонталь";
            // 
            // TargetPointXDomainUpDown
            // 
            this.TargetPointXDomainUpDown.Items.Add("7");
            this.TargetPointXDomainUpDown.Items.Add("6");
            this.TargetPointXDomainUpDown.Items.Add("5");
            this.TargetPointXDomainUpDown.Items.Add("4");
            this.TargetPointXDomainUpDown.Items.Add("3");
            this.TargetPointXDomainUpDown.Items.Add("2");
            this.TargetPointXDomainUpDown.Items.Add("1");
            this.TargetPointXDomainUpDown.Items.Add("0");
            this.TargetPointXDomainUpDown.Location = new System.Drawing.Point(83, 45);
            this.TargetPointXDomainUpDown.Name = "TargetPointXDomainUpDown";
            this.TargetPointXDomainUpDown.Size = new System.Drawing.Size(35, 20);
            this.TargetPointXDomainUpDown.TabIndex = 2;
            this.TargetPointXDomainUpDown.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вертикаль";
            // 
            // TargetPointYDomainUpDown
            // 
            this.TargetPointYDomainUpDown.Items.Add("7");
            this.TargetPointYDomainUpDown.Items.Add("6");
            this.TargetPointYDomainUpDown.Items.Add("5");
            this.TargetPointYDomainUpDown.Items.Add("4");
            this.TargetPointYDomainUpDown.Items.Add("3");
            this.TargetPointYDomainUpDown.Items.Add("2");
            this.TargetPointYDomainUpDown.Items.Add("1");
            this.TargetPointYDomainUpDown.Items.Add("0");
            this.TargetPointYDomainUpDown.Location = new System.Drawing.Point(83, 19);
            this.TargetPointYDomainUpDown.Name = "TargetPointYDomainUpDown";
            this.TargetPointYDomainUpDown.Size = new System.Drawing.Size(35, 20);
            this.TargetPointYDomainUpDown.TabIndex = 0;
            this.TargetPointYDomainUpDown.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 45);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номер завдання";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(103, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.Wheat;
            this.ResultButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResultButton.Location = new System.Drawing.Point(21, 225);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(95, 30);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.Wheat;
            this.ResultTextBox.Location = new System.Drawing.Point(158, 203);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(185, 52);
            this.ResultTextBox.TabIndex = 8;
            this.ResultTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шахи (Завалій Іван)   ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown StartPointYDomainUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown StartPointXDomainUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown TargetPointXDomainUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown TargetPointYDomainUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox ResultTextBox;
    }
}

