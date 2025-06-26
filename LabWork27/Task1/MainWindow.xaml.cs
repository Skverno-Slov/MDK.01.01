using System.Windows;
using Task1.Pages;


namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.CurrentFrame = ContentFrame;
            ContentFrame.Navigate(new StartPage());
        }

        private void OpenPage1Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new AuthorizationPage());
        }

        private void OpenPage2Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new RegistrationPage());
        }

        private void OpenPage3Button_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new SettingsPage());
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            
        }
    }
}