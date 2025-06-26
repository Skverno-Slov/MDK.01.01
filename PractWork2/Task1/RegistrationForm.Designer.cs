namespace Task1
{
    partial class RegistrationForm
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
            RegistrationButton = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // RegistrationButton
            // 
            RegistrationButton.Location = new Point(194, 166);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(142, 23);
            RegistrationButton.TabIndex = 0;
            RegistrationButton.Text = "Зарегистрироваться";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(29, 41);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(100, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(29, 112);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(29, 23);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(44, 15);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(29, 94);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(52, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Пароль:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 201);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(RegistrationButton);
            Name = "RegistrationForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrationButton;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
    }
}
