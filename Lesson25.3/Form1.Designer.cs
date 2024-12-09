namespace Lesson25._3
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
            dataGridViewInentors = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            textBoxName = new TextBox();
            textBoxCount = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDesc = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonEdit = new Button();
            textBoxSearch = new TextBox();
            comboBoxFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInentors).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInentors
            // 
            dataGridViewInentors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInentors.Location = new Point(12, 70);
            dataGridViewInentors.Name = "dataGridViewInentors";
            dataGridViewInentors.Size = new Size(607, 456);
            dataGridViewInentors.TabIndex = 0;
            dataGridViewInentors.CellClick += dataGridViewInentors_CellClick;
            dataGridViewInentors.KeyDown += dataGridViewInentors_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(118, 17);
            toolStripStatusLabelCount.Text = "toolStripStatusLabel1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(633, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Название";
            textBoxName.Size = new Size(339, 33);
            textBoxName.TabIndex = 2;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(633, 80);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.PlaceholderText = "Количество";
            textBoxCount.Size = new Size(339, 33);
            textBoxCount.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(633, 131);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Цена";
            textBoxPrice.Size = new Size(339, 33);
            textBoxPrice.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(633, 182);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.PlaceholderText = "Пояснение";
            textBoxDesc.Size = new Size(339, 288);
            textBoxDesc.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранToolStripMenuItem
            // 
            сохранToolStripMenuItem.Name = "сохранToolStripMenuItem";
            сохранToolStripMenuItem.Size = new Size(133, 22);
            сохранToolStripMenuItem.Text = "Сохранить";
            сохранToolStripMenuItem.Click += сохранToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(133, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(633, 479);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 47);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(809, 479);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(163, 47);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += button1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 31);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Введите строку для поиска";
            textBoxSearch.Size = new Size(364, 33);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Название", "Количество", "Цена" });
            comboBoxFilter.Location = new Point(397, 31);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(222, 33);
            comboBoxFilter.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(comboBoxFilter);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxName);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridViewInentors);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Урок 25";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInentors).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInentors;
        private StatusStrip statusStrip1;
        private TextBox textBoxName;
        private TextBox textBoxCount;
        private TextBox textBoxPrice;
        private TextBox textBoxDesc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button buttonAdd;
        private Button buttonEdit;
        private ToolStripStatusLabel toolStripStatusLabelCount;
        private TextBox textBoxSearch;
        private ComboBox comboBoxFilter;
    }
}
