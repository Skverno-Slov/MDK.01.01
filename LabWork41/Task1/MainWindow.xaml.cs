using System.Windows;
using System.Windows.Media.Animation;

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
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new();
            animation.Duration = TimeSpan.FromSeconds(1);

            animation.To = HamburgerMenu.Width == 0 ? 100 : 0;

            HamburgerMenu.BeginAnimation(WidthProperty, animation);
        }
    }
}