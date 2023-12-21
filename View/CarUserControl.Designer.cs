namespace View
{
    partial class CarUserControl
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
            textBoxConsumptionPerKm = new TextBox();
            textBoxDistance = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBoxConsumptionPerKm.Location = new Point(207, 40);
            textBoxConsumptionPerKm.Name = "textBoxConsumptionPerKm";
            textBoxConsumptionPerKm.Size = new Size(60, 27);
            textBoxConsumptionPerKm.TabIndex = 7;
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(207, 5);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(60, 27);
            textBoxDistance.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 5;
            label1.Text = "Расход топлива на км";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 4;
            textBox1.Text = "Расстояние в км";
            // 
            // CarUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxConsumptionPerKm);
            Controls.Add(textBoxDistance);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CarUserControl1";
            Size = new Size(276, 111);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConsumptionPerKm;
        private TextBox textBoxDistance;
        private Label label1;
        private TextBox textBox1;
    }
}
