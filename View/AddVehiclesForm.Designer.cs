namespace View
{
    partial class AddVehiclesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVehiclesForm));
            buttonOk = new Button();
            comboVehiclesSelection = new ComboBox();
            buttonClouse = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            hybridCarUserControl1 = new HybridCarUserControl();
            helicopterUserControl1 = new HelicopterUserControl();
            carUserControl1 = new CarUserControl();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.BackColor = SystemColors.ScrollBar;
            buttonOk.Enabled = false;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(59, 273);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += ButtonOk;
            // 
            // comboVehiclesSelection
            // 
            comboVehiclesSelection.FormattingEnabled = true;
            comboVehiclesSelection.Location = new Point(30, 50);
            comboVehiclesSelection.Name = "comboVehiclesSelection";
            comboVehiclesSelection.Size = new Size(169, 28);
            comboVehiclesSelection.TabIndex = 4;
            comboVehiclesSelection.SelectedIndexChanged += ComboBoxVehiclesSelection;
            // 
            // buttonClouse
            // 
            buttonClouse.BackColor = SystemColors.ScrollBar;
            buttonClouse.FlatStyle = FlatStyle.Flat;
            buttonClouse.Location = new Point(235, 273);
            buttonClouse.Name = "buttonClouse";
            buttonClouse.Size = new Size(94, 29);
            buttonClouse.TabIndex = 5;
            buttonClouse.Text = "Выход";
            buttonClouse.UseVisualStyleBackColor = false;
            buttonClouse.Click += ButtonClouse;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Location = new Point(20, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 79);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип транспортного средства";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox2.Controls.Add(hybridCarUserControl1);
            groupBox2.Controls.Add(helicopterUserControl1);
            groupBox2.Controls.Add(carUserControl1);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(30, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 153);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Значения величин";
            // 
            // hybridCarUserControl1
            // 
            hybridCarUserControl1.Location = new Point(26, 28);
            hybridCarUserControl1.Name = "hybridCarUserControl1";
            hybridCarUserControl1.Size = new Size(276, 111);
            hybridCarUserControl1.TabIndex = 2;
            // 
            // helicopterUserControl1
            // 
            helicopterUserControl1.Location = new Point(26, 28);
            helicopterUserControl1.Name = "helicopterUserControl1";
            helicopterUserControl1.Size = new Size(276, 111);
            helicopterUserControl1.TabIndex = 1;
            // 
            // carUserControl1
            // 
            carUserControl1.Location = new Point(26, 28);
            carUserControl1.Name = "carUserControl1";
            carUserControl1.Size = new Size(276, 111);
            carUserControl1.TabIndex = 0;
            // 
            // AddVehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.ocr;
            ClientSize = new Size(388, 320);
            Controls.Add(buttonClouse);
            Controls.Add(comboVehiclesSelection);
            Controls.Add(buttonOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddVehiclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление транспорта";
            Load += VehicleLoad;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private ComboBox comboVehiclesSelection;
        private Button buttonClouse;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private HybridCarUserControl hybridCarUserControl1;
        private HelicopterUserControl helicopterUserControl1;
        private CarUserControl carUserControl1;
    }
}