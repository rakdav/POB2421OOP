namespace Lesson19._1
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
            progressPB = new ProgressBar();
            StartBTN = new Button();
            SecondThreadProcessPB = new ProgressBar();
            buttonSecond = new Button();
            SuspendLayout();
            // 
            // progressPB
            // 
            progressPB.Location = new Point(14, 24);
            progressPB.Name = "progressPB";
            progressPB.Size = new Size(761, 23);
            progressPB.TabIndex = 0;
            // 
            // StartBTN
            // 
            StartBTN.Location = new Point(673, 64);
            StartBTN.Name = "StartBTN";
            StartBTN.Size = new Size(102, 23);
            StartBTN.TabIndex = 1;
            StartBTN.Text = "Запуск";
            StartBTN.UseVisualStyleBackColor = true;
            StartBTN.Click += StartBTN_Click;
            // 
            // SecondThreadProcessPB
            // 
            SecondThreadProcessPB.Location = new Point(14, 103);
            SecondThreadProcessPB.Name = "SecondThreadProcessPB";
            SecondThreadProcessPB.Size = new Size(761, 23);
            SecondThreadProcessPB.TabIndex = 2;
            // 
            // buttonSecond
            // 
            buttonSecond.Location = new Point(673, 145);
            buttonSecond.Name = "buttonSecond";
            buttonSecond.Size = new Size(102, 23);
            buttonSecond.TabIndex = 3;
            buttonSecond.Text = "Запуск";
            buttonSecond.UseVisualStyleBackColor = true;
            buttonSecond.Click += buttonSecond_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 205);
            Controls.Add(buttonSecond);
            Controls.Add(SecondThreadProcessPB);
            Controls.Add(StartBTN);
            Controls.Add(progressPB);
            Name = "Form1";
            Text = "Потоки";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressPB;
        private Button StartBTN;
        private ProgressBar SecondThreadProcessPB;
        private Button buttonSecond;
    }
}
