namespace SequencesSum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Condition1CheckBox = new System.Windows.Forms.CheckBox();
            this.Condition1ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.Condition2ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.Condition2CheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.Condition3ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.Condition3CheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уведіть значення n";
            // 
            // InputNumericUpDown
            // 
            this.InputNumericUpDown.Location = new System.Drawing.Point(119, 23);
            this.InputNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.InputNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputNumericUpDown.Name = "InputNumericUpDown";
            this.InputNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.InputNumericUpDown.TabIndex = 1;
            this.InputNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Умова завдання";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.richTextBox1.Location = new System.Drawing.Point(36, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(220, 40);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Визначте значення суми перших n цілих натуральних чисел.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат";
            // 
            // Condition1CheckBox
            // 
            this.Condition1CheckBox.AutoSize = true;
            this.Condition1CheckBox.Location = new System.Drawing.Point(13, 65);
            this.Condition1CheckBox.Name = "Condition1CheckBox";
            this.Condition1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Condition1CheckBox.TabIndex = 5;
            this.Condition1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Condition1ResultTextBox
            // 
            this.Condition1ResultTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Condition1ResultTextBox.Location = new System.Drawing.Point(262, 62);
            this.Condition1ResultTextBox.Name = "Condition1ResultTextBox";
            this.Condition1ResultTextBox.ReadOnly = true;
            this.Condition1ResultTextBox.Size = new System.Drawing.Size(180, 40);
            this.Condition1ResultTextBox.TabIndex = 6;
            this.Condition1ResultTextBox.Text = "";
            // 
            // Condition2ResultTextBox
            // 
            this.Condition2ResultTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Condition2ResultTextBox.Location = new System.Drawing.Point(262, 108);
            this.Condition2ResultTextBox.Name = "Condition2ResultTextBox";
            this.Condition2ResultTextBox.ReadOnly = true;
            this.Condition2ResultTextBox.Size = new System.Drawing.Size(180, 40);
            this.Condition2ResultTextBox.TabIndex = 9;
            this.Condition2ResultTextBox.Text = "";
            // 
            // Condition2CheckBox
            // 
            this.Condition2CheckBox.AutoSize = true;
            this.Condition2CheckBox.Location = new System.Drawing.Point(13, 111);
            this.Condition2CheckBox.Name = "Condition2CheckBox";
            this.Condition2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Condition2CheckBox.TabIndex = 8;
            this.Condition2CheckBox.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.richTextBox4.Location = new System.Drawing.Point(36, 108);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(220, 40);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = "Визначте значення суми перших n членів ряду непарних чисел 1, 3, 5, 7...";
            // 
            // Condition3ResultTextBox
            // 
            this.Condition3ResultTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.Condition3ResultTextBox.Location = new System.Drawing.Point(262, 154);
            this.Condition3ResultTextBox.Name = "Condition3ResultTextBox";
            this.Condition3ResultTextBox.ReadOnly = true;
            this.Condition3ResultTextBox.Size = new System.Drawing.Size(180, 40);
            this.Condition3ResultTextBox.TabIndex = 12;
            this.Condition3ResultTextBox.Text = "";
            // 
            // Condition3CheckBox
            // 
            this.Condition3CheckBox.AutoSize = true;
            this.Condition3CheckBox.Location = new System.Drawing.Point(13, 157);
            this.Condition3CheckBox.Name = "Condition3CheckBox";
            this.Condition3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.Condition3CheckBox.TabIndex = 11;
            this.Condition3CheckBox.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox6.Location = new System.Drawing.Point(36, 154);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(220, 40);
            this.richTextBox6.TabIndex = 10;
            this.richTextBox6.Text = "Визначте значення суми перших n членів ряду 1+1/2+1/3+1/4+...";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CalculateButton.Location = new System.Drawing.Point(262, 7);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 35);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Обчислити";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 204);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Condition3ResultTextBox);
            this.Controls.Add(this.Condition3CheckBox);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.Condition2ResultTextBox);
            this.Controls.Add(this.Condition2CheckBox);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.Condition1ResultTextBox);
            this.Controls.Add(this.Condition1CheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Суми послідовностей (Завалій Іван)";
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown InputNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Condition1CheckBox;
        private System.Windows.Forms.RichTextBox Condition1ResultTextBox;
        private System.Windows.Forms.RichTextBox Condition2ResultTextBox;
        private System.Windows.Forms.CheckBox Condition2CheckBox;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox Condition3ResultTextBox;
        private System.Windows.Forms.CheckBox Condition3CheckBox;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button CalculateButton;
    }
}

