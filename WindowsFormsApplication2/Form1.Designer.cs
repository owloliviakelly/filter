namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.median3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.median5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianXY1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianXY3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianXY5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edgeSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveUsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveUsToolStripMenuItem
            // 
            this.saveUsToolStripMenuItem.Name = "saveUsToolStripMenuItem";
            this.saveUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveUsToolStripMenuItem.Text = "Save us...";
            this.saveUsToolStripMenuItem.Click += new System.EventHandler(this.saveUsToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianToolStripMenuItem,
            this.median3ToolStripMenuItem,
            this.median5ToolStripMenuItem,
            this.medianXY1ToolStripMenuItem,
            this.medianXY3ToolStripMenuItem,
            this.medianXY5ToolStripMenuItem,
            this.edgeSelectionToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medianToolStripMenuItem.Text = "Median 3";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.median3ToolStripMenuItem_Click);
            // 
            // median3ToolStripMenuItem
            // 
            this.median3ToolStripMenuItem.Name = "median3ToolStripMenuItem";
            this.median3ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.median3ToolStripMenuItem.Text = "Median 5";
            this.median3ToolStripMenuItem.Click += new System.EventHandler(this.median5ToolStripMenuItem_Click);
            // 
            // median5ToolStripMenuItem
            // 
            this.median5ToolStripMenuItem.Name = "median5ToolStripMenuItem";
            this.median5ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.median5ToolStripMenuItem.Text = "Median 7";
            this.median5ToolStripMenuItem.Click += new System.EventHandler(this.median7ToolStripMenuItem_Click);
            // 
            // medianXY1ToolStripMenuItem
            // 
            this.medianXY1ToolStripMenuItem.Name = "medianXY1ToolStripMenuItem";
            this.medianXY1ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medianXY1ToolStripMenuItem.Text = "Median XY 3";
            this.medianXY1ToolStripMenuItem.Click += new System.EventHandler(this.medianXY3ToolStripMenuItem_Click);
            // 
            // medianXY3ToolStripMenuItem
            // 
            this.medianXY3ToolStripMenuItem.Name = "medianXY3ToolStripMenuItem";
            this.medianXY3ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medianXY3ToolStripMenuItem.Text = "Median XY 5";
            this.medianXY3ToolStripMenuItem.Click += new System.EventHandler(this.medianXY5ToolStripMenuItem_Click);
            // 
            // medianXY5ToolStripMenuItem
            // 
            this.medianXY5ToolStripMenuItem.Name = "medianXY5ToolStripMenuItem";
            this.medianXY5ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medianXY5ToolStripMenuItem.Text = "Median XY 7";
            this.medianXY5ToolStripMenuItem.Click += new System.EventHandler(this.medianXY7ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 383);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(499, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 383);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // edgeSelectionToolStripMenuItem
            // 
            this.edgeSelectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.edgeSelectionToolStripMenuItem.Name = "edgeSelectionToolStripMenuItem";
            this.edgeSelectionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.edgeSelectionToolStripMenuItem.Text = "Edge_Selection";
            this.edgeSelectionToolStripMenuItem.Click += new System.EventHandler(this.edgeSelectionToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grayToolStripMenuItem.Text = "Gray ";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Фильтры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem median3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem median5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianXY1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianXY3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianXY5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

