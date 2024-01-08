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
            panel5 = new Panel();
            buttonFilterExit = new Button();
            buttonFilter = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            buttonReset = new Button();
            dataGridViewFuel = new DataGridView();
            buttonDelete = new Button();
            ButtonAddVehicles = new Button();
            panel3 = new Panel();
            buttonRandom = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuel).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(buttonFilterExit);
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(buttonReset);
            groupBox1.Controls.Add(dataGridViewFuel);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(ButtonAddVehicles);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(14, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Расчёт затраченного топлива";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(-1, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(9, 1);
            panel5.TabIndex = 2;
            // 
            // buttonFilterExit
            // 
            buttonFilterExit.BackColor = SystemColors.ScrollBar;
            buttonFilterExit.FlatAppearance.BorderColor = Color.Gray;
            buttonFilterExit.FlatStyle = FlatStyle.Flat;
            buttonFilterExit.Location = new Point(496, 359);
            buttonFilterExit.Name = "buttonFilterExit";
            buttonFilterExit.Size = new Size(140, 29);
            buttonFilterExit.TabIndex = 8;
            buttonFilterExit.Text = "Очистить фильтр";
            buttonFilterExit.UseVisualStyleBackColor = false;
            buttonFilterExit.Click += ButtonCleanFilter_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.BackColor = SystemColors.ScrollBar;
            buttonFilter.FlatAppearance.BorderColor = Color.Gray;
            buttonFilter.FlatStyle = FlatStyle.Flat;
            buttonFilter.Location = new Point(345, 359);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(94, 29);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Фильтр";
            buttonFilter.UseVisualStyleBackColor = false;
            buttonFilter.Click += ButtonSearch_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Location = new Point(0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 395);
            panel4.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(-2, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 1);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(218, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 1);
            panel1.TabIndex = 1;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = SystemColors.ScrollBar;
            buttonReset.FlatAppearance.BorderColor = Color.Gray;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(695, 359);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Очистить";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += ButtonReset_Click;
            // 
            // dataGridViewFuel
            // 
            dataGridViewFuel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuel.Location = new Point(13, 74);
            dataGridViewFuel.Name = "dataGridViewFuel";
            dataGridViewFuel.RowHeadersWidth = 51;
            dataGridViewFuel.RowTemplate.Height = 29;
            dataGridViewFuel.Size = new Size(776, 270);
            dataGridViewFuel.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.BackgroundImage = Properties.Resources.minus;
            buttonDelete.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(56, 28);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(41, 37);
            buttonDelete.TabIndex = 4;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonAddVehicles
            // 
            ButtonAddVehicles.BackColor = Color.Transparent;
            ButtonAddVehicles.BackgroundImage = Properties.Resources.add1;
            ButtonAddVehicles.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonAddVehicles.FlatAppearance.BorderSize = 0;
            ButtonAddVehicles.FlatStyle = FlatStyle.Flat;
            ButtonAddVehicles.Location = new Point(9, 28);
            ButtonAddVehicles.Name = "ButtonAddVehicles";
            ButtonAddVehicles.Size = new Size(47, 37);
            ButtonAddVehicles.TabIndex = 1;
            ButtonAddVehicles.UseVisualStyleBackColor = false;
            ButtonAddVehicles.Click += ButtonAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(815, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 395);
            panel3.TabIndex = 5;
            // 
            // buttonRandom
            // 
            buttonRandom.BackColor = SystemColors.ScrollBar;
            buttonRandom.FlatAppearance.BorderColor = Color.Gray;
            buttonRandom.FlatStyle = FlatStyle.Flat;
            buttonRandom.ForeColor = SystemColors.WindowText;
            buttonRandom.Location = new Point(26, 389);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(262, 29);
            buttonRandom.TabIndex = 3;
            buttonRandom.Text = "Случайное транспортное средство";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += ButtonRandom_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.BackgroundImageLayout = ImageLayout.Zoom;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.GripMargin = new Padding(0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(61, 27);
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
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(166, 26);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // VehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.ocr;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(830, 449);
            Controls.Add(toolStrip1);
            Controls.Add(panel3);
            Controls.Add(buttonRandom);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
    }
}