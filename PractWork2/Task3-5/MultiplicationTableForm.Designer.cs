namespace Task3_5
{
    partial class MultiplicationTableForm
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
            CreateTableButton = new Button();
            SuspendLayout();
            // 
            // CreateTableButton
            // 
            CreateTableButton.Location = new Point(59, 112);
            CreateTableButton.Name = "CreateTableButton";
            CreateTableButton.Size = new Size(205, 39);
            CreateTableButton.TabIndex = 0;
            CreateTableButton.Text = "Создать таблицу умножения";
            CreateTableButton.UseVisualStyleBackColor = true;
            CreateTableButton.Click += CreateTableButton_Click;
            // 
            // MultiplicationTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 250);
            Controls.Add(CreateTableButton);
            Name = "MultiplicationTableForm";
            Text = "Таблица умножения";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateTableButton;
    }
}
