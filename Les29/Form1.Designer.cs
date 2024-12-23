namespace Les29
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьXlsxToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            dataGridViewTovar = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovar).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьXlsxToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть ...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьXlsxToolStripMenuItem
            // 
            сохранитьXlsxToolStripMenuItem.Name = "сохранитьXlsxToolStripMenuItem";
            сохранитьXlsxToolStripMenuItem.Size = new Size(180, 22);
            сохранитьXlsxToolStripMenuItem.Text = "Сохранить xlsx ...";
            сохранитьXlsxToolStripMenuItem.Click += сохранитьXlsxToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // dataGridViewTovar
            // 
            dataGridViewTovar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTovar.Location = new Point(12, 27);
            dataGridViewTovar.Name = "dataGridViewTovar";
            dataGridViewTovar.Size = new Size(776, 411);
            dataGridViewTovar.TabIndex = 1;
            dataGridViewTovar.ColumnHeaderMouseClick += dataGridViewTovar_ColumnHeaderMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewTovar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Товарная накладная";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private DataGridView dataGridViewTovar;
        private ToolStripMenuItem сохранитьXlsxToolStripMenuItem;
    }
}
