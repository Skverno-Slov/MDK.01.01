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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = e.OriginalSource as RadioButton;
            InputTextBox.FontSize = Convert.ToInt32(radioButton.Content);
        }

        private void AlignRight_Checked(object sender, RoutedEventArgs e)
        {
            InputTextBox.TextAlignment = TextAlignment.Right;
        }

        private void AlignCenter_Checked(object sender, RoutedEventArgs e)
        {
            InputTextBox.TextAlignment = TextAlignment.Center;
        }

        private void AlignLeft_Checked(object sender, RoutedEventArgs e)
        {
            InputTextBox.TextAlignment = TextAlignment.Left;
        }
    }
}