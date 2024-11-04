namespace Lesson17
{
    partial class FormRegistration
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
            textBoxLogin = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxPasswordRepeat = new TextBox();
            dateTimePickerBirth = new DateTimePicker();
            buttonReg = new Button();
            labelWarning = new Label();
            labelPasswordWarning = new Label();
            labelEmailWarning = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(62, 43);
            textBoxLogin.Margin = new Padding(5, 6, 5, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(439, 35);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(62, 102);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Введите имя";
            textBoxFirstName.Size = new Size(439, 35);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(62, 164);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите фамилию";
            textBoxLastName.Size = new Size(439, 35);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(62, 223);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите адрес электронной почты";
            textBoxEmail.Size = new Size(439, 35);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(62, 281);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(439, 35);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxPasswordRepeat
            // 
            textBoxPasswordRepeat.Location = new Point(62, 339);
            textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            textBoxPasswordRepeat.PasswordChar = '*';
            textBoxPasswordRepeat.PlaceholderText = "Повторите пароль";
            textBoxPasswordRepeat.Size = new Size(439, 35);
            textBoxPasswordRepeat.TabIndex = 5;
            textBoxPasswordRepeat.TextChanged += textBoxPasswordRepeat_TextChanged;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(62, 397);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(439, 35);
            dateTimePickerBirth.TabIndex = 6;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(149, 525);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(266, 62);
            buttonReg.TabIndex = 7;
            buttonReg.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.BackColor = Color.White;
            labelWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(62, 319);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 17);
            labelWarning.TabIndex = 8;
            // 
            // labelPasswordWarning
            // 
            labelPasswordWarning.AutoSize = true;
            labelPasswordWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPasswordWarning.ForeColor = Color.Red;
            labelPasswordWarning.Location = new Point(62, 377);
            labelPasswordWarning.Name = "labelPasswordWarning";
            labelPasswordWarning.Size = new Size(0, 17);
            labelPasswordWarning.TabIndex = 9;
            // 
            // labelEmailWarning
            // 
            labelEmailWarning.AutoSize = true;
            labelEmailWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEmailWarning.ForeColor = Color.Red;
            labelEmailWarning.Location = new Point(63, 262);
            labelEmailWarning.Name = "labelEmailWarning";
            labelEmailWarning.Size = new Size(0, 17);
            labelEmailWarning.TabIndex = 10;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Автор", "Читатель" });
            comboBoxRole.Location = new Point(62, 456);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(439, 38);
            comboBoxRole.TabIndex = 11;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 636);
            Controls.Add(comboBoxRole);
            Controls.Add(labelEmailWarning);
            Controls.Add(labelPasswordWarning);
            Controls.Add(labelWarning);
            Controls.Add(buttonReg);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(textBoxPasswordRepeat);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLogin);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormRegistration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxPasswordRepeat;
        private DateTimePicker dateTimePickerBirth;
        private Button buttonReg;
        private Label labelWarning;
        private Label labelPasswordWarning;
        private Label labelEmailWarning;
        public ComboBox comboBoxRole;
    }
}