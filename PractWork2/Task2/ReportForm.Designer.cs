namespace Task2
{
    partial class ReportForm
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
            GenerateReportButton = new Button();
            StatusLabel = new Label();
            SuspendLayout();
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Location = new Point(110, 73);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(114, 23);
            GenerateReportButton.TabIndex = 0;
            GenerateReportButton.Text = "Создать отчёт";
            GenerateReportButton.UseVisualStyleBackColor = true;
            GenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Dock = DockStyle.Bottom;
            StatusLabel.FlatStyle = FlatStyle.Flat;
            StatusLabel.Location = new Point(0, 144);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(269, 15);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Выберите папку для анализа и нажмите кнопку";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 159);
            Controls.Add(StatusLabel);
            Controls.Add(GenerateReportButton);
            Name = "ReportForm";
            Text = "Генератор отчётов Excel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateReportButton;
        private Label StatusLabel;
    }
}
