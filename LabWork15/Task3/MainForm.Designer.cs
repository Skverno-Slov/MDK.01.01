namespace Task3
{
    partial class MainForm
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
            OpenReplacementFormButton = new Button();
            EnterTextBox = new TextBox();
            SuspendLayout();
            // 
            // OpenReplacementFormButton
            // 
            OpenReplacementFormButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenReplacementFormButton.Location = new Point(693, 12);
            OpenReplacementFormButton.Name = "OpenReplacementFormButton";
            OpenReplacementFormButton.Size = new Size(75, 23);
            OpenReplacementFormButton.TabIndex = 0;
            OpenReplacementFormButton.Text = "Заменить";
            OpenReplacementFormButton.UseVisualStyleBackColor = true;
            OpenReplacementFormButton.Click += OpenReplacementFormButton_Click;
            // 
            // EnterTextBox
            // 
            EnterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterTextBox.Cursor = Cursors.IBeam;
            EnterTextBox.Location = new Point(12, 12);
            EnterTextBox.Multiline = true;
            EnterTextBox.Name = "EnterTextBox";
            EnterTextBox.Size = new Size(675, 426);
            EnterTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(EnterTextBox);
            Controls.Add(OpenReplacementFormButton);
            Name = "MainForm";
            Text = "Ввод текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenReplacementFormButton;
        private TextBox EnterTextBox;
    }
}
