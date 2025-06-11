namespace AmoebaHouse
{
    partial class MainForm
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
            this.AmoebaFormButton = new System.Windows.Forms.Button();
            this.HouseFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmoebaFormButton
            // 
            this.AmoebaFormButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AmoebaFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.AmoebaFormButton.Location = new System.Drawing.Point(60, 58);
            this.AmoebaFormButton.Name = "AmoebaFormButton";
            this.AmoebaFormButton.Size = new System.Drawing.Size(110, 40);
            this.AmoebaFormButton.TabIndex = 0;
            this.AmoebaFormButton.Text = "Амеба";
            this.AmoebaFormButton.UseVisualStyleBackColor = false;
            this.AmoebaFormButton.Click += new System.EventHandler(this.AmoebaFormButton_Click);
            // 
            // HouseFormButton
            // 
            this.HouseFormButton.BackColor = System.Drawing.Color.SandyBrown;
            this.HouseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.HouseFormButton.Location = new System.Drawing.Point(194, 58);
            this.HouseFormButton.Name = "HouseFormButton";
            this.HouseFormButton.Size = new System.Drawing.Size(110, 40);
            this.HouseFormButton.TabIndex = 1;
            this.HouseFormButton.Text = "Будиночок";
            this.HouseFormButton.UseVisualStyleBackColor = false;
            this.HouseFormButton.Click += new System.EventHandler(this.HouseFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 167);
            this.Controls.Add(this.HouseFormButton);
            this.Controls.Add(this.AmoebaFormButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Амеба, Будиночок (Завалій Іван)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AmoebaFormButton;
        private System.Windows.Forms.Button HouseFormButton;
    }
}

