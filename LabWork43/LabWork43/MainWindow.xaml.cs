using System;
using System.Net;
using System.Windows;

using System.Windows.Threading;

namespace LabWork43
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new();
        private int _cookies = 0;
        private int _grandmother = 0;
        private int _price = 15;

        public MainWindow()
        {
            InitializeComponent();

            CookiesTimerStart();
            Pause();
        }

        private void AddCookie()
            => _cookies++;

        private void CookiesTimerStart()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }

        private void BuyHelp()
            => _cookies -= _price;

        private void AddCookieOnClick()
        {
            AddCookie();
            UpdateCookiesCountLable();
            Pause();
        }

        private void Pause()
        {
            GrandmotherRectangle.IsEnabled = _cookies >= _price;
            GrandmotherRectangle.Opacity = _cookies >= _price ? 1 : 0.5;
        }
        private void UpdateMotherCountLable()
            => GrandmotherCountLable.Content = $"Бабушек {_grandmother }";

        private void UpdateCookiesCountLable()
            => CookiesCountLable.Content = $"Печенек {_cookies}";

        private void GrandMotherTimerStart()
        {
            _grandmother++;
            UpdateMotherCountLable();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / _grandmother);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
            => AddCookieOnClick();

        private void ClickerEllipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
            => AddCookieOnClick();

        private void GrandmotherRectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            BuyHelp();
            UpdateCookiesCountLable();
            Pause();
            GrandMotherTimerStart();
        }
    }
}