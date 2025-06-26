using System.Windows;
using System.Windows.Media;

namespace Task5
{
    /// <summary>
    /// Логика взаимодействия для ColorDialogWindow.xaml
    /// </summary>
    public partial class ColorDialogWindow : Window
    {
        public Color SelectedColor { get; set; }

        public ColorDialogWindow()
        {
            InitializeComponent();
            UpdateColorPreview();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void UpdateColorPreview()
        {
            SelectedColor = Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            PreviewRectangle.Fill = new SolidColorBrush(SelectedColor);
        }

        private void SliderValue_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateColorPreview();
        }
    }
}
