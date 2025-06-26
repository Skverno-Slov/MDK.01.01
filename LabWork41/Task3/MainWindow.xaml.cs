using System.Windows;
using System.Windows.Media.Animation;

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

        private DoubleAnimation WidthAnimation()
        {
            DoubleAnimation animation = new();
            animation.To = 400;
            animation.Duration = TimeSpan.FromSeconds(1);
            animation.AutoReverse = true;
            animation.RepeatBehavior = new(2);
            return animation;
        }
        private DoubleAnimation HeightAnimation()
        {
            DoubleAnimation animation = new();
            animation.To = 400;
            animation.Duration = TimeSpan.FromSeconds(1);
            animation.AutoReverse = true;
            animation.RepeatBehavior = new(2);
            return animation;
        }

        private DoubleAnimation TextSizeAnimation()
        {
            DoubleAnimation animation = new();
            animation.To = 24;
            animation.Duration = TimeSpan.FromSeconds(1);
            animation.AutoReverse = true;
            animation.RepeatBehavior = new(2);
            return animation;
        }

        private void AnimatedButton_Loaded(object sender, RoutedEventArgs e)
        {
            AnimatedButton.BeginAnimation(FontSizeProperty, TextSizeAnimation());
            AnimatedButton.BeginAnimation(WidthProperty, WidthAnimation());
            AnimatedButton.BeginAnimation(HeightProperty, HeightAnimation());
        }
    }
}