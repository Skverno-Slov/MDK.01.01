using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace LabWork35
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?",
                "Подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Title = "Выберите имя файла",
                Filter = "Текстовые файлы|*.txt; *.html; *.cs; *.css; *.js; *.sql",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            if (dialog.ShowDialog() != true)
                return;

            MainTextBox.Text = File.ReadAllText(dialog.FileName);
            Title = dialog.SafeFileName;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new()
            {
                Title = "Выберите имя файла",
                Filter = "Текстовые файлы|*.txt; *.html; *.cs; *.css; *.js; *.sql",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (dialog.ShowDialog() != true)
                return;

            File.WriteAllText(dialog.FileName, MainTextBox.Text);
            
            MessageBox.Show("Файл успешно сохранён",
                "Сохранение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}