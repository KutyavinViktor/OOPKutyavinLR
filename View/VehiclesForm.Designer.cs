namespace View
{
    partial class VehiclesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesForm));
            groupBox1 = new GroupBox();
            dataGridViewFuel = new DataGridView();
            ButtonAddVehicles = new Button();
            buttonRandom = new Button();
            buttonDelete = new Button();
            buttonReset = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            buttonFilter = new Button();
            buttonFilterExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuel).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dataGridViewFuel);
            groupBox1.Location = new Point(42, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Расчёт затраченного топлива";
            // 
            // dataGridViewFuel
            // 
            dataGridViewFuel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuel.Location = new Point(18, 26);
            dataGridViewFuel.Name = "dataGridViewFuel";
            dataGridViewFuel.RowHeadersWidth = 51;
            dataGridViewFuel.RowTemplate.Height = 29;
            dataGridViewFuel.Size = new Size(669, 270);
            dataGridViewFuel.TabIndex = 0;
            // 
            // ButtonAddVehicles
            // 
            ButtonAddVehicles.BackColor = Color.Transparent;
            ButtonAddVehicles.BackgroundImage = Properties.Resources.add1;
            ButtonAddVehicles.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonAddVehicles.FlatAppearance.BorderSize = 0;
            ButtonAddVehicles.FlatStyle = FlatStyle.Flat;
            ButtonAddVehicles.Location = new Point(602, 343);
            ButtonAddVehicles.Name = "ButtonAddVehicles";
            ButtonAddVehicles.Size = new Size(54, 47);
            ButtonAddVehicles.TabIndex = 1;
            ButtonAddVehicles.UseVisualStyleBackColor = false;
            ButtonAddVehicles.Click += ButtonAdd_Click;
            // 
            // buttonRandom
            // 
            buttonRandom.Location = new Point(62, 399);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(262, 29);
            buttonRandom.TabIndex = 3;
            buttonRandom.Text = "Случайное транспортное средство";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += ButtonRandom_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.BackgroundImage = Properties.Resources.minus;
            buttonDelete.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(662, 343);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(57, 47);
            buttonDelete.TabIndex = 4;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(637, 399);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Очистить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.BackgroundImageLayout = ImageLayout.Zoom;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.GripMargin = new Padding(0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(792, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, загрузитьToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(59, 24);
            toolStripDropDownButton1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(224, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(224, 26);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(351, 399);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(94, 29);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Фильтр";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += ButtonSearch_Click;
            // 
            // buttonFilterExit
            // 
            buttonFilterExit.Location = new Point(471, 399);
            buttonFilterExit.Name = "buttonFilterExit";
            buttonFilterExit.Size = new Size(140, 29);
            buttonFilterExit.TabIndex = 8;
            buttonFilterExit.Text = "Очистить фильтр";
            buttonFilterExit.UseVisualStyleBackColor = true;
            buttonFilterExit.Click += ButtonCleanFilter_Click;
            // 
            // VehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.ocr;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(792, 449);
            Controls.Add(buttonFilterExit);
            Controls.Add(buttonFilter);
            Controls.Add(toolStrip1);
            Controls.Add(buttonReset);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRandom);
            Controls.Add(ButtonAddVehicles);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "VehiclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчёт объёма топлива транспортных средств";
            Load += VehiclesForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuel).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewFuel;
        private Button ButtonAddVehicles;
        private Button buttonRandom;
        private Button buttonDelete;
        private Button buttonReset;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private Button buttonFilter;
        private Button buttonFilterExit;
    }
}