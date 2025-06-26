using DBlibrary;
using System.Windows;

namespace LabWork46
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataBase _dataBase = new SqlDatabase("mssql", "ispp3114", "ispp3114", "3114");
        //private readonly IDataBase _dataBase = new SqliteDatabase("C:\\temp\\ispp31\\LabWorks\\LabWork46-20250610T053211Z-1-001\\LabWork46\\LabWork46\\bin\\Debug\\net9.0-windows", "db1.sqlite");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateResult(string query)
        {
            int affectedRows = _dataBase.ExecuteQuery(query);
            ResultTextBlock.Text = affectedRows.ToString();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string query = QueryTextBox.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(query))
                    return;

                UpdateResult(query);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при выполнении команды");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleParametrTextBox.Text;
            const string CorrectMessage = "Команда успешно выполнена";
            const string UncorrectMessage = "Строки не были затронуты";

            if (!int.TryParse(IdParametrTextBox.Text, out int id)
                && IdParametrTextBox.Text.Trim() == string.Empty)
                return;

            if (title.Trim() == string.Empty)
                return;

            if (!decimal.TryParse(PriceParametrTextBox.Text, out decimal price)
                && PriceParametrTextBox.Text.Trim() == string.Empty)
                return;

            try
            {
                UpdateResultTextBlock.Text = _dataBase.UpdateGame(id, title, price) ? CorrectMessage : UncorrectMessage;
            }
            catch
            {
                MessageBox.Show("Ошибка при выполнении запроса");
            }
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleParametrTextBox.Text;

            if (!DateTime.TryParse(DateParametrTextBox.Text, out DateTime date)
                && DateParametrTextBox.Text.Trim() == string.Empty)
                return;

            if (title.Trim() == string.Empty)
                return;

            if (!decimal.TryParse(PriceParametrTextBox.Text, out decimal price)
                && PriceParametrTextBox.Text.Trim() == string.Empty)
                return;

            try
            {
                _dataBase.InsertGame(title, price, date.Year);
                MessageBox.Show("Данные успешно внесены в таблицу");
            }
            catch
            {
                MessageBox.Show("Ошибка при выполнении запроса");
            }
        }
    }
}