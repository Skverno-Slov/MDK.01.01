using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LabWork37
{
    public partial class MainWindow : Window
    {
        private DirectoryInfo _directory;
        private IEnumerable<FileInfo>? _files;
        private IEnumerable<FileInfo> _filteredFiles;
        private const string PATH = @"C:\Users\THUNDER\source\repos\ScientificConference\ScientificConference";

        public MainWindow()
        {
            LoadDirectiry(PATH);
            LoadFiles();

            InitializeComponent();

            UpdateListView();
        }

        private void LoadDirectiry(string path)
            => _directory = new DirectoryInfo(path);

        private void LoadFiles()
        {
            _files = _directory.GetFiles().AsEnumerable();
            _filteredFiles = _files;
        }

        private void UpdateListView()
        {
            if (_filteredFiles is null)
                return;

            if (FilesListView is null)
                return;

            FilesListView.ItemsSource = _filteredFiles.Select(file => new
            {
                Name = file.Name,
                Extension = file.Extension,
                Path = file.FullName,
                Size = file.Length,
                CreationTime = file.CreationTime,
                LastWriteTime = file.LastWriteTime
            });

            CountLabel.Text = $"Показано {_filteredFiles.Count()} из {_files.Count()} записей";
        }

        private void FindAnyFile()
        {
            if (!_filteredFiles.Any())
                MessageBox.Show("Нет файлов, соответствующих условию фильтрации по размеру.");
        }

        private void CancelCheckBoxFilter()
        {
            ApplySizeRadioButtonFilter();
            ApplyDateChangeFilter();
        }

        private void ApplySizeCheckboxFilter()
        {
            bool isMinConverted = long.TryParse(TextBoxMinSize.Text, out long minSize);
            bool isMaxConverted = long.TryParse(TextBoxMaxSize.Text, out long maxSize);

            CancelCheckBoxFilter();

            if (MinSizeCheckBox.IsChecked is true && isMinConverted)
                _filteredFiles = _filteredFiles.Where(f => f.Length >= minSize);

            if (MaxSizeCheckBox.IsChecked is true && isMaxConverted)
                _filteredFiles = _filteredFiles.Where(f => f.Length <= maxSize);

            FindAnyFile();
            UpdateListView();
        }

        private void ApplySizeRadioButtonFilter()
        {

            if (AllSizesRadioButton.IsChecked is true)
                _filteredFiles = _files;
            else
            {
                bool isSizeLimitConverted = long.TryParse(SizeTextBox.Text, out long sizeLimit);
                if (!isSizeLimitConverted)
                {
                    MessageBox.Show("Введите циферки");
                    return;
                }

                if (MoreOrEqualRadioButton.IsChecked is true)
                    _filteredFiles = _files.Where(f => f.Length >= sizeLimit);
                else
                    _filteredFiles = _files.Where(f => f.Length <= sizeLimit);
            }
            FindAnyFile();
            UpdateListView();
        }

        private void ApplyDateChangeFilter()
        {
            var result = _files;
            if (ShowAfterCheckBox.IsChecked is true && ChangeDatePicker.SelectedDate.HasValue)
            {
                DateTime date = ChangeDatePicker.SelectedDate.Value;
                result = result.Where(f => f.LastWriteTime > date);
            }

            _filteredFiles = result;
            FindAnyFile();
            UpdateListView();
        }

        private void ApplyCreateDateFilter()
        {
            string selectedOption = (CreateDateComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            DateTime now = DateTime.Now;
            IEnumerable<FileInfo> result = _files;

            if (selectedOption == "Сегодня")
                result = _files.Where(f => f.CreationTime.Date == now.Date);
            else if (selectedOption == "За последнюю неделю")
            {
                var weekAgo = now.AddDays(-7);
                result = _files.Where(f => f.CreationTime >= weekAgo);
            }
            else if (selectedOption == "В этом месяце")
                result = _files.Where(f => f.CreationTime.Month == now.Month && f.CreationTime.Year == now.Year);

            _filteredFiles = result;
            FindAnyFile();
            UpdateListView();
        }

        private void ApplyFilters() { }

        private void TextBoxNameFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string fileNamePart = NameFilterTextBox.Text.ToLower();
            _filteredFiles = _files.Where(f => f.Name.ToLower().Contains(fileNamePart));

            UpdateListView();
        }

        private void ButtonResetFilter_Click(object sender, RoutedEventArgs e)
        {
            AllSizesRadioButton.IsChecked = true;
            MinSizeCheckBox.IsChecked = false;
            MaxSizeCheckBox.IsChecked = false;
            ShowAfterCheckBox.IsChecked = false;
            NameFilterTextBox.Text = "";          
            ChangeDatePicker.Text = "";
            CreateDateComboBox.SelectedValue = null;
            UpdateListView();
        }

        private void RadioButtonSize_Checked(object sender, RoutedEventArgs e)
            => ApplySizeRadioButtonFilter();
 
        private void TextBoxMaxSizeCheckbox_LostFocus(object sender, RoutedEventArgs e)
            => ApplySizeCheckboxFilter();

        private void CheckBoxSize_Checked(object sender, RoutedEventArgs e)
            => ApplySizeCheckboxFilter();

        private void CheckBoxShowAfter_Checked(object sender, RoutedEventArgs e)
            => ApplyDateChangeFilter();

        private void DatePickerChange_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
            => ApplyDateChangeFilter();

        private void ComboBoxCreateDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
            => ApplyCreateDateFilter();
    }
}