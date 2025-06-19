using System.Windows;
using DBlibrary;

namespace LabWork46
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataBase _dataBase = new SqlDatabase("mssql", "ispp3114", "ispp3114", "3114");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateResult(string query)
        {
            int affectedRows = _dataBase.ExecuteQuery(@"UPDATE Game
                    SET price += 1;");
            ResultTextBlock.Text = affectedRows.ToString();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string query = QueryTextBox.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                UpdateResult(@"UPDATE Game
                    SET price += 1;");
                return;
            }

            UpdateResult(query);
        }
    }
}