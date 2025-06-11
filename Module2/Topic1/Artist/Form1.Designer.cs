
namespace Artist
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SunflowersRadioButton = new System.Windows.Forms.RadioButton();
            this.IrisesRadioButton = new System.Windows.Forms.RadioButton();
            this.StarryNightRadioButton = new System.Windows.Forms.RadioButton();
            this.TerraceRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вінсент ван Гог";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Location = new System.Drawing.Point(34, 334);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(253, 93);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "\nВінсент ван Гог\n\n(30 березня 1853 - 29 липня 1890)\n\nНідерландський художник, пос" +
    "тімпресіоніст.";
            // 
            // SunflowersRadioButton
            // 
            this.SunflowersRadioButton.AutoSize = true;
            this.SunflowersRadioButton.Location = new System.Drawing.Point(409, 90);
            this.SunflowersRadioButton.Name = "SunflowersRadioButton";
            this.SunflowersRadioButton.Size = new System.Drawing.Size(93, 19);
            this.SunflowersRadioButton.TabIndex = 3;
            this.SunflowersRadioButton.Text = "Соняшники";
            this.SunflowersRadioButton.UseVisualStyleBackColor = true;
            this.SunflowersRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // IrisesRadioButton
            // 
            this.IrisesRadioButton.AutoSize = true;
            this.IrisesRadioButton.Location = new System.Drawing.Point(409, 113);
            this.IrisesRadioButton.Name = "IrisesRadioButton";
            this.IrisesRadioButton.Size = new System.Drawing.Size(58, 19);
            this.IrisesRadioButton.TabIndex = 4;
            this.IrisesRadioButton.TabStop = true;
            this.IrisesRadioButton.Text = "Іриси";
            this.IrisesRadioButton.UseVisualStyleBackColor = true;
            this.IrisesRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // StarryNightRadioButton
            // 
            this.StarryNightRadioButton.AutoSize = true;
            this.StarryNightRadioButton.Checked = true;
            this.StarryNightRadioButton.Location = new System.Drawing.Point(409, 136);
            this.StarryNightRadioButton.Name = "StarryNightRadioButton";
            this.StarryNightRadioButton.Size = new System.Drawing.Size(90, 19);
            this.StarryNightRadioButton.TabIndex = 5;
            this.StarryNightRadioButton.TabStop = true;
            this.StarryNightRadioButton.Text = "Зоряна ніч";
            this.StarryNightRadioButton.UseVisualStyleBackColor = true;
            this.StarryNightRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // TerraceRadioButton
            // 
            this.TerraceRadioButton.AutoSize = true;
            this.TerraceRadioButton.Location = new System.Drawing.Point(409, 159);
            this.TerraceRadioButton.Name = "TerraceRadioButton";
            this.TerraceRadioButton.Size = new System.Drawing.Size(136, 19);
            this.TerraceRadioButton.TabIndex = 6;
            this.TerraceRadioButton.TabStop = true;
            this.TerraceRadioButton.Text = "Тераса кафе вночі";
            this.TerraceRadioButton.UseVisualStyleBackColor = true;
            this.TerraceRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(534, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TerraceRadioButton);
            this.Controls.Add(this.StarryNightRadioButton);
            this.Controls.Add(this.IrisesRadioButton);
            this.Controls.Add(this.SunflowersRadioButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Художник (Завалій Іван)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton SunflowersRadioButton;
        private System.Windows.Forms.RadioButton IrisesRadioButton;
        private System.Windows.Forms.RadioButton StarryNightRadioButton;
        private System.Windows.Forms.RadioButton TerraceRadioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

