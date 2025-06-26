using Microsoft.Win32;
using System.IO;
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

namespace LabWork34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Save,
                SaveExecuted,
                SaveCanExecuted));

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Close,
                CloseExecuted));
        }

        private void CloseExecuted(object sender, ExecutedRoutedEventArgs e) 
            => Close();

        private void SaveCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = MainTextBox.Text.Length > 0;
        }

        private async void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog SaveFileDialog = new();
            SaveFileDialog.Filter = "Текстовый формат(*.txt)|*.txt";
            if (!SaveFileDialog.ShowDialog().Value)
                return;

            using (StreamWriter writer = new(SaveFileDialog.FileName))
            {
                writer.Write(MainTextBox.Text);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextLengthStatusBarItem.Content = $"Количество символов: {MainTextBox.Text.Length}";
        }

        private void ReduceSizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextBox.FontSize > 10)
                SizeSlider.Value -= 10;
        }

        private void IncreaseSizeButton_Click(object sender, RoutedEventArgs e)
        {
            SizeSlider.Value += 10;
        }

        private void StatusBarVisibilityMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            StatusBar.Visibility = StatusBarVisibilityMenuItem.IsChecked ? Visibility.Visible : Visibility.Collapsed;
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
            => MainTextBox.Clear();
    }
}