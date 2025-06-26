using System.IO;
using System.Windows;

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            LoadWindow();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("userData.txt", $"{LoginTextBox.Text}\n{PasswordTextBox.Text}\n{EmailTextBox.Text}");

            MessageBox.Show("Сохранено");
        }

        private void LoadWindow()
        {
            string[] lines = File.ReadAllLines("userData.txt");

            LoginTextBox.Text = lines[0];
            PasswordTextBox.Text = lines[1];
            EmailTextBox.Text = lines[2];
        }
    }
}
