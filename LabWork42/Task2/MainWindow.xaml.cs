using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> imagePaths = new();
        private int currentImageIndex = 0;
        private DispatcherTimer timer = new();

        public MainWindow()
        {
            InitializeComponent();
            timer.Start();
        }

        private void SelectionFolderButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new();
            if (dialog.ShowDialog() == true)
            {
                foreach (string path in Directory.GetFiles(dialog.FolderName, "*.png"))
                    imagePaths.Add(path);
            }

            if (imagePaths.Count > 0)
            {
                currentImageIndex = 0;
                ShowCurrentImage();

                timer.Tick += new EventHandler(DispatcherTimer_Tick);
                timer.Interval = TimeSpan.FromSeconds(0.3);
                timer.Start();
            }
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Count;
            ShowCurrentImage();
        }

        private void ShowCurrentImage()
        {
            if (imagePaths.Count > 0)
            {
                BitmapImage bitmap = new(new Uri(imagePaths[currentImageIndex]));
                Images.Source = bitmap;
            }
        }
    }
}
