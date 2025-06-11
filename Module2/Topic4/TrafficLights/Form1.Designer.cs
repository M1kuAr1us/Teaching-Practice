namespace TrafficLights
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
            this.GoLightButton = new System.Windows.Forms.Button();
            this.ReadyLightButton = new System.Windows.Forms.Button();
            this.StopLightButton = new System.Windows.Forms.Button();
            this.Light3 = new System.Windows.Forms.PictureBox();
            this.Light2 = new System.Windows.Forms.PictureBox();
            this.Light1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrafficLightsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GoLightButton);
            this.panel1.Controls.Add(this.ReadyLightButton);
            this.panel1.Controls.Add(this.StopLightButton);
            this.panel1.Controls.Add(this.Light3);
            this.panel1.Controls.Add(this.Light2);
            this.panel1.Controls.Add(this.Light1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 370);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // GoLightButton
            // 
            this.GoLightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoLightButton.Location = new System.Drawing.Point(206, 99);
            this.GoLightButton.Name = "GoLightButton";
            this.GoLightButton.Size = new System.Drawing.Size(90, 30);
            this.GoLightButton.TabIndex = 5;
            this.GoLightButton.Text = "Йди";
            this.GoLightButton.UseVisualStyleBackColor = true;
            this.GoLightButton.Click += new System.EventHandler(this.TrafficLightsButton_Click);
            // 
            // ReadyLightButton
            // 
            this.ReadyLightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ReadyLightButton.Location = new System.Drawing.Point(206, 63);
            this.ReadyLightButton.Name = "ReadyLightButton";
            this.ReadyLightButton.Size = new System.Drawing.Size(90, 30);
            this.ReadyLightButton.TabIndex = 4;
            this.ReadyLightButton.Text = "Чекай";
            this.ReadyLightButton.UseVisualStyleBackColor = true;
            this.ReadyLightButton.Click += new System.EventHandler(this.TrafficLightsButton_Click);
            // 
            // StopLightButton
            // 
            this.StopLightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StopLightButton.Location = new System.Drawing.Point(206, 27);
            this.StopLightButton.Name = "StopLightButton";
            this.StopLightButton.Size = new System.Drawing.Size(90, 30);
            this.StopLightButton.TabIndex = 2;
            this.StopLightButton.Text = "Стій";
            this.StopLightButton.UseVisualStyleBackColor = true;
            this.StopLightButton.Click += new System.EventHandler(this.TrafficLightsButton_Click);
            // 
            // Light3
            // 
            this.Light3.BackColor = System.Drawing.Color.DimGray;
            this.Light3.Image = global::TrafficLights.Properties.Resources.gray;
            this.Light3.Location = new System.Drawing.Point(40, 239);
            this.Light3.Name = "Light3";
            this.Light3.Size = new System.Drawing.Size(100, 100);
            this.Light3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Light3.TabIndex = 3;
            this.Light3.TabStop = false;
            // 
            // Light2
            // 
            this.Light2.BackColor = System.Drawing.Color.DimGray;
            this.Light2.Image = global::TrafficLights.Properties.Resources.gray;
            this.Light2.Location = new System.Drawing.Point(40, 133);
            this.Light2.Name = "Light2";
            this.Light2.Size = new System.Drawing.Size(100, 100);
            this.Light2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Light2.TabIndex = 2;
            this.Light2.TabStop = false;
            // 
            // Light1
            // 
            this.Light1.BackColor = System.Drawing.Color.DimGray;
            this.Light1.Image = global::TrafficLights.Properties.Resources.gray;
            this.Light1.Location = new System.Drawing.Point(40, 27);
            this.Light1.Name = "Light1";
            this.Light1.Size = new System.Drawing.Size(100, 100);
            this.Light1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Light1.TabIndex = 1;
            this.Light1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(20, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 340);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrafficLightsButton
            // 
            this.TrafficLightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TrafficLightsButton.Location = new System.Drawing.Point(133, 12);
            this.TrafficLightsButton.Name = "TrafficLightsButton";
            this.TrafficLightsButton.Size = new System.Drawing.Size(90, 30);
            this.TrafficLightsButton.TabIndex = 1;
            this.TrafficLightsButton.Text = "Світлофор";
            this.TrafficLightsButton.UseVisualStyleBackColor = true;
            this.TrafficLightsButton.Click += new System.EventHandler(this.TrafficLightsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.TrafficLightsButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Світлофор (Завалій Іван)";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Light3;
        private System.Windows.Forms.PictureBox Light2;
        private System.Windows.Forms.PictureBox Light1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TrafficLightsButton;
        private System.Windows.Forms.Button GoLightButton;
        private System.Windows.Forms.Button ReadyLightButton;
        private System.Windows.Forms.Button StopLightButton;
    }
}

