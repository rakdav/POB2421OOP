namespace Lesson24._1
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
            dataGridViewUsers = new DataGridView();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAge = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 7);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(737, 642);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(757, 9);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(215, 35);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(757, 62);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(215, 35);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(755, 114);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Возраст";
            textBoxAge.Size = new Size(217, 35);
            textBoxAge.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(757, 167);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(215, 42);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(758, 224);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(214, 46);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewUsers);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Урок 24";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAge;
        private Button buttonAdd;
        private Button buttonEdit;
    }
}
