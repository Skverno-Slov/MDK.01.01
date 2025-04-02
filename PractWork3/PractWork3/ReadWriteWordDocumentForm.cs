using Word = Microsoft.Office.Interop.Word;

namespace PractWork3
{
    public partial class ReadWriteWordDocumentForm : Form
    {
        public ReadWriteWordDocumentForm()
        {
            InitializeComponent();
        }


        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            int taskCount;
            if (!int.TryParse(InputTaskCountTextBox.Text, out taskCount) || taskCount < 0)
            {
                MessageBox.Show("Некорректно введены данные");
                return;
            }

            Word.Application wordApp = new Word.Application();
            var fileName = Path.Combine(Environment.CurrentDirectory, "Шаблон.docx");
            Word.Document document = wordApp.Documents.Open(fileName);
            wordApp.Visible = true;

            ReplaceText(document, "ТекстИзПоляВвода", InputTextBox.Text);
            ReplaceText(document, "дд.мм.гггг чч:мм", DateTime.Now.ToString());

            Word.Table table = document.Tables[1];
            for (int i = 0; i < taskCount-1; i++)
                document.Tables[1].Rows.Add();

            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Word-документы|*.docx|PDF-файлы|*.pdf";
            saveFileDialog.Title = "Сохранить как";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        document.SaveAs2(saveFileDialog.FileName, Word.WdSaveFormat.wdFormatXMLDocument);
                        break;
                    default:
                        document.SaveAs2(saveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                        break;
                }
            }

            document.Close();
        }

        private void ReplaceText(Word.Document document, string oldText, string newText)
        {
            document.Content.Find.Execute(FindText: oldText, ReplaceWith: newText);
        }
    }
}
