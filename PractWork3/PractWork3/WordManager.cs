using Word = Microsoft.Office.Interop.Word;

public class WordManager
{
    private Word.Application _wordApp;
    private Word.Document _document;
    private Word.Range _range;

    private const int MaxPictureHeight = 50;
    private const int TableHead = 1;
    private const int TableBody = 2;
    private const int TableCountRows = 2;

    public void AddImage()
    {
        AddParagraph();
        var fileName = Path.Combine(Environment.CurrentDirectory, "picture.jpg");
        Word.InlineShape inlineShape = _range.InlineShapes.AddPicture(fileName);
        _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
        var height = inlineShape.Height;
        float coefficient = inlineShape.Height / MaxPictureHeight;
        inlineShape.Height = MaxPictureHeight;
        inlineShape.Width = inlineShape.Width / coefficient;
    }

    private void AddParagraph()
    {
        var paragraph = _document.Paragraphs.Add();
        _range = paragraph.Range;
    }

    public void AddTable()
    {
        AddParagraph();
        var table = _document.Tables.Add(_range, TableHead, TableCountRows);
        table.Borders.Enable = 1;
    }

    public void FormatDocument()
    {
        _range.Font.Name = "Times New Roman";
        _range.Font.Size = 14;
        _range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
    }

    public void SaveDocument(string fileName)
    {
        if (fileName.EndsWith(".docx"))
            _document.SaveAs2(fileName);
        else
            _document.SaveAs2(fileName, Word.WdSaveFormat.wdFormatPDF);
    }

    public void AddRowsToTable(int taskCount, int currentTable)
    {
        Word.Table table = _document.Tables[currentTable];
        for (int i = 0; i <= taskCount - 1; i++)
            _document.Tables[currentTable].Rows.Add();
    }

    public void CreateDocument()
    {
        _wordApp = new();
        _document = _wordApp.Documents.Add();
        _wordApp.Visible = true;
    }

    public void OpenTemplate()
    {
        var fileName = Path.Combine(Environment.CurrentDirectory, "Шаблон.docx");
        if (!File.Exists(fileName))
            throw new FileNotFoundException($"{fileName} не найден");

        _wordApp = new();
        _wordApp.Visible = true;

        _document = _wordApp.Documents.Open(fileName);
    }

    public void ReplaceText(string oldText, string newText)
    {
        _document.Content.Find.Execute(FindText: oldText, ReplaceWith: newText);
    }

    public void CloseDocument()
    {
        _document.Close();
        _wordApp.Quit();
    }

    public void AddText(string text)
    {
        AddParagraph();
        _range.Text = $"{text}\n";
    }

    public void AddDateTime()
    {
        AddParagraph();
        _range.InsertDateTime();
    }

    public void FillTable(int taskCount, int currentTable)
    {
        Word.Table table = _document.Tables[currentTable];
        table.Cell(TableHead, 1).Range.Text = "№";
        table.Cell(TableHead, 2).Range.Text = "Текст";
        for (int i = 0; i <= taskCount - 1; i++)
            table.Cell(TableBody + i, 1).Range.Text = $"{i + 1}";
    }

    public void AddEmptyParagraph()
    {
        _document.Paragraphs.Add();
    }
}


