using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
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

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            GradientBrush.GradientStops[0].BeginAnimation(GradientStop.ColorProperty, ColorAnimation());
        }

        private ColorAnimationUsingKeyFrames ColorAnimation()
        {
            ColorAnimationUsingKeyFrames animation = new();
            animation.Duration = TimeSpan.FromSeconds(1);

            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Orange, KeyTime.FromPercent(0.0)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromPercent(0.25)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Green, KeyTime.FromPercent(0.5)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Blue, KeyTime.FromPercent(0.75)));
            animation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Purple, KeyTime.FromPercent(1.0)));
            return animation;
        }
    }
}