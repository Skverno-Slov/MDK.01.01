using Microsoft.Office.Interop.Word;

namespace PractWork3
{
    public partial class CreateWordDocumentForm : Form
    {

        public CreateWordDocumentForm()
        {
            InitializeComponent();
        }


        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            WordManager manager = new();

            manager.OpenTemplate();

            manager.ReplaceText("ТекстИзПоляВвода", InputTextBox.Text);
            manager.ReplaceText("дд.мм.гггг чч:мм", DateTime.Now.ToString());
            manager.AddEmptyParagraph();

            manager.AddRowsToTable((int)InputTaskCountNumericUpDown.Value - 1, 1);
            manager.FillTable((int)InputTaskCountNumericUpDown.Value, 1);

            manager.AddText("Таблица 1 - Задания");
            manager.AddEmptyParagraph();
            manager.AddTable();
            manager.AddRowsToTable((int)InputTaskCountNumericUpDown.Value, 2);
            manager.FillTable((int)InputTaskCountNumericUpDown.Value, 2);
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Word-документы|*.docx|PDF-файлы|*.pdf";
            saveFileDialog.Title = "Сохранить как";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                manager.SaveDocument(saveFileDialog.FileName);
            else 
                MessageBox.Show("Сохранение отменено");

            manager.CloseDocument();
        }

        private void CreateNewDocumentButton_Click(object sender, EventArgs e)
        {
            WordManager manager = new();

            manager.CreateDocument();

            manager.AddImage();

            manager.AddText($"{InputTextBox.Text}\n");
            manager.FormatDocument();

            manager.AddDateTime();
        }
    }
}
