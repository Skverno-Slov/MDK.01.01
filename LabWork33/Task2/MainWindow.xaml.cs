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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadUsersDataGrid();
        }

        public void LoadUsersDataGrid()
        {
            var users = new List<User>()
            {
                new()
                {
                    Login = "Admin",
                    Password = "Password",
                    Address = "Admin@mail.com",
                    Category = "email",
                    IsArchived = true
                },
                new()
                {
                    Login = "user1",
                    Password = "qwerty",
                    Address = "user1@mail.com",
                    Category = "email",
                    IsArchived = true,
                },
                new()
                {
                    Login = "user2",
                    Password = "qwerty123",
                    Address = "user2DataBase",
                    Category = "БД",
                    IsArchived = true,
                },
                new()
                {
                    Login = "user3",
                    Password = "Password123",
                    Address = "arcotel.org",
                    Category = "сайт",
                    IsArchived = false,
                },
                new()
                {
                    Login = "user4",
                    Password = "Passwordqwerty",
                    Address = "youtube.com",
                    Category = "сайт",
                    IsArchived = false,
                }
            };

            UsersDataGrid.ItemsSource = users;
            UsersDataGrid.AlternatingRowBackground = Brushes.Green;
        }

        private void CopyPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            var user = e.Source as User;
            Clipboard.SetDataObject(user?.HiddenPassword);
        }
    }
}