using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task4
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

        private Random random = new Random();
        private string[] tags = { "enemy", "hero", "treasure" };

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse circle = new Ellipse();
            int size = random.Next(20, 60);
            byte r = (byte)random.Next(256);
            byte g = (byte)random.Next(256);
            byte b = (byte)random.Next(256);
            string tag = tags[random.Next(tags.Length)];

            circle.Width = size;
            circle.Height = size;
            circle.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
            circle.Stroke = Brushes.Black;
            circle.Tag = tag;

            Point position = e.GetPosition(drawingCanvas);
            Canvas.SetLeft(circle, position.X - size / 2);
            Canvas.SetTop(circle, position.Y - size / 2);

            circle.MouseDown += (s, args) =>
            {
                MessageBox.Show($"Тег элемента: {((Ellipse)s).Tag}");
                args.Handled = true;
            };

            drawingCanvas.Children.Add(circle);
        }
    }
}