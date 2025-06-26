using Microsoft.Win32;
using System.IO;
using System.Media;
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
            VideoPlayer.Source = new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Videos", "VID_20250606_101259_113.mp4"));
        }

        private void FirstSystemSoundButton_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void SecondSystemSoundButton_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void FirstFileSoundButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer mediaPlayer = new();
            mediaPlayer.Open(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Sounds","cicada_night_forest.mp3")));
            mediaPlayer.Play();
        }

        private void SecondFileSoundButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer mediaPlayer = new();
            mediaPlayer.Open(new Uri(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Sounds", "forest-night-2.mp3")));
            mediaPlayer.Play();
        }

        private void VideoPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Position = TimeSpan.Zero;
        }
    }
}