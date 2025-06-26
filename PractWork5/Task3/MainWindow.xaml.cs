using System.Windows;

namespace Task3
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

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow window = new();
            window.Show();
        }
    }
}