using Excel = Microsoft.Office.Interop.Excel;

namespace Task3_5
{
    public partial class MultiplicationTableForm : Form
    {
        public MultiplicationTableForm()
        {
            InitializeComponent();
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application { Visible = false };
                workbook = excelApp.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Умножение";

                for (int i = 1; i <= 9; i++)
                {
                    worksheet.Cells[i + 8, 4] = i;
                    worksheet.Cells[8, i + 2] = i;

                    for (int j = 1; j <= 9; j++)
                    {
                        worksheet.Cells[i + 8, j + 2] = i * j;
                    }
                }

                Excel.Range header = worksheet.Range["C8", "K8"];
                header.Merge();
                header.Value = "Таблица умножения";
                header.Font.Bold = true;
                header.Font.Italic = true;
                header.Font.Size = 20;
                header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                Excel.Range tableRange = worksheet.Range["C9", "K17"];
                tableRange.Font.Size = 15;
                tableRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                tableRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                tableRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                for (int i = 9; i <= 19; i++)
                    worksheet.Cells[i, 3].Interior.Color = Excel.XlRgbColor.rgbLightGray;

                for (int i = 3; i <= 11; i++)
                    worksheet.Cells[9, i].Interior.Color = Excel.XlRgbColor.rgbLightGray;

                worksheet.Columns["C:K"].AutoFit();
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                workbook?.Close(false);
                excelApp?.Quit();
            }

            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Табличный документ | *.xlsx";
            saveFileDialog.ShowDialog();
        }
    }
}

