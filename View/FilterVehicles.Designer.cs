namespace View
{
    partial class FilterVehicles
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
            groupBoxFilter = new GroupBox();
            textBoxFilter = new TextBox();
            buttonAdd = new Button();
            checkBoxInput = new CheckBox();
            checkBoxHybridCar = new CheckBox();
            checkBoxHelicopter = new CheckBox();
            checkBoxCar = new CheckBox();
            groupBoxFilter.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.BackColor = Color.Transparent;
            groupBoxFilter.Controls.Add(textBoxFilter);
            groupBoxFilter.Controls.Add(buttonAdd);
            groupBoxFilter.Controls.Add(checkBoxInput);
            groupBoxFilter.Controls.Add(checkBoxHybridCar);
            groupBoxFilter.Controls.Add(checkBoxHelicopter);
            groupBoxFilter.Controls.Add(checkBoxCar);
            groupBoxFilter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxFilter.Location = new Point(12, 12);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(345, 189);
            groupBoxFilter.TabIndex = 0;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Тип транспортного средства";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Enabled = false;
            textBoxFilter.Location = new Point(237, 144);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(86, 27);
            textBoxFilter.TabIndex = 4;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Transparent;
            buttonAdd.BackgroundImage = Properties.Resources.magnifier;
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.FlatAppearance.BorderColor = Color.Gray;
            buttonAdd.FlatAppearance.BorderSize = 3;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.Transparent;
            buttonAdd.Location = new Point(237, 38);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 78);
            buttonAdd.TabIndex = 1;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonSearch_Click;
            // 
            // checkBoxInput
            // 
            checkBoxInput.AutoSize = true;
            checkBoxInput.Location = new Point(20, 146);
            checkBoxInput.Name = "checkBoxInput";
            checkBoxInput.Size = new Size(218, 24);
            checkBoxInput.TabIndex = 3;
            checkBoxInput.Text = "Точная стоимость топлива";
            checkBoxInput.UseVisualStyleBackColor = true;
            checkBoxInput.CheckedChanged += CheckBoxInput_CheckedChanged;
            // 
            // checkBoxHybridCar
            // 
            checkBoxHybridCar.AutoSize = true;
            checkBoxHybridCar.Location = new Point(19, 109);
            checkBoxHybridCar.Name = "checkBoxHybridCar";
            checkBoxHybridCar.Size = new Size(82, 24);
            checkBoxHybridCar.TabIndex = 2;
            checkBoxHybridCar.Text = "Гибрид";
            checkBoxHybridCar.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelicopter
            // 
            checkBoxHelicopter.AutoSize = true;
            checkBoxHelicopter.Location = new Point(19, 70);
            checkBoxHelicopter.Name = "checkBoxHelicopter";
            checkBoxHelicopter.Size = new Size(94, 24);
            checkBoxHelicopter.TabIndex = 1;
            checkBoxHelicopter.Text = "Вертолёт";
            checkBoxHelicopter.UseVisualStyleBackColor = true;
            // 
            // checkBoxCar
            // 
            checkBoxCar.AutoSize = true;
            checkBoxCar.Location = new Point(19, 32);
            checkBoxCar.Name = "checkBoxCar";
            checkBoxCar.Size = new Size(118, 24);
            checkBoxCar.TabIndex = 0;
            checkBoxCar.Text = "Автомобиль";
            checkBoxCar.UseVisualStyleBackColor = true;
            // 
            // FilterVehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.ocr;
            ClientSize = new Size(368, 213);
            Controls.Add(groupBoxFilter);
            MaximizeBox = false;
            Name = "FilterVehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilterVehicles";
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFilter;
        private CheckBox checkBoxCar;
        private CheckBox checkBoxHelicopter;
        private CheckBox checkBoxInput;
        private CheckBox checkBoxHybridCar;
        private Button buttonAdd;
        private TextBox textBoxFilter;
    }
}