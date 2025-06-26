using System.Windows;

namespace LabWork26
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

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow((string)Task1Button.Content);
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow((string)Task2Button.Content);
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow((string)Task3Button.Content);
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow((string)Task4Button.Content);
        }

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow((string)Task5Button.Content);
        }

        void OpenWindow(string content)
        {
            switch (content)
            {
                case "Задание 1":
                    Window1 window1 = new Window1();
                    window1.Show();
                    break;
                case "Задание 2":
                    Window2 window2 = new Window2();
                    window2.Show();
                    break;
                case "Задание 3":
                    Window3 window3 = new Window3();
                    window3.Show();
                    break;
                case "Задание 4":
                    Window4 window4 = new Window4();
                    window4.Show();
                    break;
                case "Задание 5":
                    Window5 window5 = new Window5();
                    window5.Show();
                    break;
            }
        }
    }
}