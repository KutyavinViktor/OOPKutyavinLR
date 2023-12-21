namespace View
{
    partial class HelicopterUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 27);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 13;
            label1.Text = "Расход топлива на км";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(7, 7);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 12;
            textBox4.Text = "Расстояние в км";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 27);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 77);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Масса груза";
            // 
            // HelicopterUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Name = "HelicopterUserControl1";
            Size = new Size(276, 111);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
    }
}
