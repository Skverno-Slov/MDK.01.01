using Excel = Microsoft.Office.Interop.Excel;

namespace Task2
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new())
            {
                folderDialog.Description = "Выберите папку для анализа";

                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string selectedFolderPath = folderDialog.SelectedPath;
                string templatePath = Path.Combine(Application.StartupPath, "Шаблон.xlsx");

                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Файл шаблона не найден!", "Ошибка",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Excel.Application excelApp = null;
                Excel.Workbook workbook = null;

                try
                {
                    excelApp = new Excel.Application();
                    workbook = excelApp.Workbooks.Open(templatePath);

                    FillFilesWorksheet(workbook.Sheets["Файлы"], selectedFolderPath);
                    FillFoldersWorksheet(workbook.Sheets["Подпапки"], selectedFolderPath);

                    excelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании отчета: {ex.Message}", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    workbook?.Close(false);
                    excelApp?.Quit();
                }
            }
        }
        private static void FillFilesWorksheet(Excel.Worksheet worksheet, string folderPath)
        {
            FileInfo[] files = new DirectoryInfo(folderPath).GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                worksheet.Cells[i + 2, 1] = i + 1; // Номер
                worksheet.Cells[i + 2, 2] = files[i].Name; // Имя файла
                worksheet.Cells[i + 2, 3] = FormatFileSize(files[i].Length); // Размер
            }
        }

        private static void FillFoldersWorksheet(Excel.Worksheet worksheet, string folderPath)
        {
            DirectoryInfo[] subDirectories = new DirectoryInfo(folderPath).GetDirectories();

            for (int i = 0; i < subDirectories.Length; i++)
            {
                worksheet.Cells[i + 2, 1] = i + 1; // Номер
                worksheet.Cells[i + 2, 2] = subDirectories[i].Name; // Имя папки
            }
        }

        private static string FormatFileSize(long bytes)
        {
            string[] sizes = { "Байт", "Кб", "Мб", "Гб" };
            int order = 0;
            double size = bytes;

            while (size >= 1024 && order < sizes.Length - 1)
            {
                order++;
                size /= 1024;
            }

            return $"{size:0.##} {sizes[order]}";
        }
    }
}
