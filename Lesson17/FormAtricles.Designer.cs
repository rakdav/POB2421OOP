﻿namespace Lesson17
{
    partial class FormAtricles
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
            listBoxArticles = new ListBox();
            buttonAdd = new Button();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // listBoxArticles
            // 
            listBoxArticles.FormattingEnabled = true;
            listBoxArticles.ItemHeight = 15;
            listBoxArticles.Location = new Point(15, 12);
            listBoxArticles.Name = "listBoxArticles";
            listBoxArticles.Size = new Size(361, 349);
            listBoxArticles.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(201, 382);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(301, 382);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // FormAtricles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 427);
            Controls.Add(buttonDel);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxArticles);
            Name = "FormAtricles";
            Text = "Статьи";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxArticles;
        private Button buttonAdd;
        private Button buttonDel;
    }
}