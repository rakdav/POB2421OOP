namespace Lesson17
{
    partial class FormReadArticle
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
            labelText = new Label();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.Location = new Point(10, 9);
            labelText.Name = "labelText";
            labelText.Size = new Size(778, 432);
            labelText.TabIndex = 0;
            // 
            // FormReadArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelText);
            Name = "FormReadArticle";
            Text = "Статья";
            ResumeLayout(false);
        }

        #endregion

        private Label labelText;
    }
}