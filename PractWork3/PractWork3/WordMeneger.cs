using Microsoft.Office.Interop.Word;
using static System.Windows.Forms.DataFormats;
using Word = Microsoft.Office.Interop.Word;

public class WordMeneger
{
    public void OverrideTemplateDocument(string inputText, int inputTaskCount)
    {

        Document document = OpenDocument();

        ReplaceText(document, "ТекстИзПоляВвода", inputText);
        ReplaceText(document, "дд.мм.гггг чч:мм", DateTime.Now.ToString());

        AddRowsToTable(inputTaskCount, document);

        SaveDocument(document);

        document.Close();
    }

    public void CreateNewDocument(string inputText, int inputTaskCount)
    {
        Document document = CreateDocument();

        var range = AddParagraph(document);
        AddImage(range);

        range = AddParagraph(document);
        range.Text = $"{inputText}\n";
        
        range = AddParagraph(document);
        range.Text = "Таблица 1 — Задания\n";
        FormatDocument(document);
        range = AddParagraph(document);
        AddTable(document, range);
        AddRowsToTable(inputTaskCount + 1, document);

        range = AddParagraph(document);
        range.InsertDateTime();
    }

    private void AddImage(Word.Range range)
    {
        var fileName = Path.Combine(Environment.CurrentDirectory, "picture.jpg");
        Word.InlineShape inlineShape = range.InlineShapes.AddPicture(fileName);
        inlineShape.Width = 50;
        //inlineShape.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoTrue;
    }

    private Word.Range AddParagraph(Document document)
    {
        var paragraph = document.Paragraphs.Add();
        var range = paragraph.Range;
        return range;
    }

    private void AddTable(Document document, Word.Range range)
    {
        var table = document.Tables.Add(range, 1, 2);
        table.Cell(1, 1).Range.Text = "Задание";
        table.Cell(1, 2).Range.Text = "Описание";

    }

    private void FormatDocument(Document document)
    {
        Word.Range range = document.Content;
        range.Font.Name = "Times New Roman";
        range.Font.Size = 14;
        range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
    }

    private void SaveDocument(Document document)
    {
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
    }

    private void AddRowsToTable(int taskCount, Document document)
    {
        Word.Table table = document.Tables[1];
        for (int i = 0; i < taskCount - 1; i++)
            document.Tables[1].Rows.Add();
    }


    private Document CreateDocument()
    {
        Word.Application wordApp = new();
        Word.Document document = wordApp.Documents.Add();
        wordApp.Visible = true;
        return document;
    }
    private Document OpenDocument()
    {
        Word.Application wordApp = new();
        var fileName = Path.Combine(Environment.CurrentDirectory, "Шаблон.docx");
        Word.Document document = wordApp.Documents.Open(fileName);
        wordApp.Visible = true;
        return document;
    }

    private void ReplaceText(Word.Document document, string oldText, string newText)
    {
        document.Content.Find.Execute(FindText: oldText, ReplaceWith: newText);
    }
}


