using System.Windows;
using System.Windows.Controls;

namespace LabWork31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SymbolLeftTextBlock.Text = InformationTextBox.MaxLength.ToString();
            BirthDayDatePicker.DisplayDateEnd = DateTime.Today;
        }

        private void EnterPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordLengthTextBlock.Text = $"{EnterPasswordBox.Password.Length}";
        }

        private void InformationTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SymbolLeftTextBlock.Text = $"{InformationTextBox.MaxLength - InformationTextBox.Text.Length}";
        }

        private void BirthDayDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            int age = DateTime.Today.Year - BirthDayDatePicker.SelectedDate.Value.Year;
            if (BirthDayDatePicker.SelectedDate.Value.DayOfYear > DateTime.Today.DayOfYear)
                age--;
            AgeTexBlock.Text = $"Возраст {age}";
        }
    }
}