using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

        private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Изображения| *.jpg; *.png; *.jpeg";

            if (dialog.ShowDialog() == true)
            {
                BitmapImage bitmap = new(new Uri(dialog.FileName));
                Image image = new Image { Source = bitmap };
                DrawingCanvas.Children.Add(image);
            }
        }

        private void PenSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (DrawingCanvas != null)
            {
                DrawingCanvas.DefaultDrawingAttributes.Width = PenSizeSlider.Value;
                DrawingCanvas.DefaultDrawingAttributes.Height = PenSizeSlider.Value;
            }
        }

        private void ColorPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DrawingCanvas != null)
            {
                string colorName = (ColorPicker.SelectedItem as ComboBoxItem).Content.ToString();
                DrawingCanvas.DefaultDrawingAttributes.Color = 
                    (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(colorName);
            }
        }
    }
}