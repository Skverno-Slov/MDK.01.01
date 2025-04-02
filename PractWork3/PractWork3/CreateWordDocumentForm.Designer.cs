namespace PractWork3
{
    partial class CreateWordDocumentForm
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
            InputTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CreateDocumentButton = new Button();
            CreateNewDocumentButton = new Button();
            InputTaskCountNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)InputTaskCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            InputTextBox.Location = new Point(12, 38);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(389, 400);
            InputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Ввод текста";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(514, 143);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 3;
            label2.Text = "Количество заданий";
            // 
            // CreateDocumentButton
            // 
            CreateDocumentButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CreateDocumentButton.Location = new Point(548, 409);
            CreateDocumentButton.Name = "CreateDocumentButton";
            CreateDocumentButton.Size = new Size(240, 29);
            CreateDocumentButton.TabIndex = 4;
            CreateDocumentButton.Text = "Создать документ по шаблону";
            CreateDocumentButton.UseVisualStyleBackColor = true;
            CreateDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // CreateNewDocumentButton
            // 
            CreateNewDocumentButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CreateNewDocumentButton.Location = new Point(548, 374);
            CreateNewDocumentButton.Name = "CreateNewDocumentButton";
            CreateNewDocumentButton.Size = new Size(240, 29);
            CreateNewDocumentButton.TabIndex = 5;
            CreateNewDocumentButton.Text = "Создать новый документ";
            CreateNewDocumentButton.UseVisualStyleBackColor = true;
            CreateNewDocumentButton.Click += CreateNewDocumentButton_Click;
            // 
            // InputTaskCountNumericUpDown
            // 
            InputTaskCountNumericUpDown.Location = new Point(514, 166);
            InputTaskCountNumericUpDown.Name = "InputTaskCountNumericUpDown";
            InputTaskCountNumericUpDown.Size = new Size(152, 27);
            InputTaskCountNumericUpDown.TabIndex = 6;
            // 
            // CreateWordDocumentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InputTaskCountNumericUpDown);
            Controls.Add(CreateNewDocumentButton);
            Controls.Add(CreateDocumentButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputTextBox);
            Name = "CreateWordDocumentForm";
            Text = "Создание word-документа";
            ((System.ComponentModel.ISupportInitialize)InputTaskCountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Label label1;
        private Label label2;
        private Button CreateDocumentButton;
        private Button CreateNewDocumentButton;
        private NumericUpDown InputTaskCountNumericUpDown;
    }
}