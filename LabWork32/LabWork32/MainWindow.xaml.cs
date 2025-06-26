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

namespace LabWork32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadCategoriesListBox();
            LoadSortingTextBlock();
            LoadCategoryTextBlock();
            LoadAvaibilityTextBlock();
        }

        private void LoadAvaibilityTextBlock()
        {
            foreach (CheckBox item in AvailabilityCheckBox.Items)
                if(item.IsChecked.Value)
                    AvailabilityTextBlock.Text = item.ToString();
        }

        private void LoadCategoryTextBlock()
        {

            CategoryTextBlock.Text = $"{CategoriesListBox.SelectedItem.ToString()}";
        }

        private void LoadSortingTextBlock()
        {
            SortingTextBlock.Text = SortingComboBox.SelectedItem.ToString();
        }

        private void LoadCategoriesListBox()
        {
            List<string> categories = new()
            {
                "Продукты питания",
                "Бытовая химия",
                "Спортивый инвентарь",
                "Одежда",
                "Электроника",
                "Товары для детей",
                "Запчасти для машины",
                "Животные",
                "Услуги",
                "Товары для дома"
            };

            CategoriesListBox.ItemsSource = categories;
            CategoriesListBox.SelectedIndex = 0;
        }
    }
}