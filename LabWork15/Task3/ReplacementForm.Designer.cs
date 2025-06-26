namespace Task3
{
    partial class ReplacementForm
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
            ReplaceButton = new Button();
            SearchTextBox = new TextBox();
            ReplacementTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ReplaceButton
            // 
            ReplaceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ReplaceButton.Location = new Point(293, 138);
            ReplaceButton.Name = "ReplaceButton";
            ReplaceButton.Size = new Size(75, 23);
            ReplaceButton.TabIndex = 0;
            ReplaceButton.Text = "Заменить";
            ReplaceButton.UseVisualStyleBackColor = true;
            ReplaceButton.Click += ReplaceButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.Location = new Point(12, 34);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(356, 23);
            SearchTextBox.TabIndex = 1;
            // 
            // ReplacementTextBox
            // 
            ReplacementTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReplacementTextBox.Location = new Point(12, 109);
            ReplacementTextBox.Name = "ReplacementTextBox";
            ReplacementTextBox.Size = new Size(356, 23);
            ReplacementTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Текст для поиска";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 4;
            label2.Text = "Текст для замены";
            // 
            // ReplacementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 166);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReplacementTextBox);
            Controls.Add(SearchTextBox);
            Controls.Add(ReplaceButton);
            Name = "ReplacementForm";
            Text = "ReplacementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReplaceButton;
        private TextBox SearchTextBox;
        private TextBox ReplacementTextBox;
        private Label label1;
        private Label label2;
    }
}