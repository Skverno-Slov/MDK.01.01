using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void AuthtorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.AuthorizationPage());
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.RegistrationPage());
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.SettingsPage());
        }
    }
}
