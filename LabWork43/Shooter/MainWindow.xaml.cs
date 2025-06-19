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
using System.Windows.Threading;
using static System.Formats.Asn1.AsnWriter;

namespace Shooter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private DispatcherTimer _moveTimer = new(DispatcherPriority.Render);
        private DispatcherTimer _gameCircleTimer = new(DispatcherPriority.Render);
        private Enemy _enemyModel = new Enemy(10);
        private int _score;

        private double _arenaEnd;
        private double _arenaStart;

        public MainWindow()
        {
            InitializeComponent();
            CreateArena();

            StartGameCircleTimer();
            MoveTimerStart();
        }

        private void CreateArena()
        {
            _arenaEnd = GameCanvas.Height;
            _arenaStart = GameCanvas.Width;
        }

        private void MoveTimerStart()
        {
            _moveTimer.Interval = TimeSpan.FromMilliseconds(50);
            _moveTimer.Start();
            _moveTimer.Tick += MoveTimer_Tick;
        }

        private void StartGameCircleTimer()
        {
            _gameCircleTimer.Interval = TimeSpan.FromMilliseconds(500);
            _gameCircleTimer.Start();
            _gameCircleTimer.Tick += GameCircleTimer_Tick;
        }

        private void AddScore()
        {
            _score++;
            ScoreTextBlock.Text = $"ОЧКИ {_score}";
        }

        private void RemoveEnemy(object sender)
            => GameCanvas.Children.Remove(sender as UIElement);

        private void StopGame(double yPosition)
        {
            if (yPosition >= _arenaEnd)
            {
                _gameCircleTimer.Stop();
                _moveTimer.Stop();
                MessageBox.Show($"End\n Score {_score}");
            }
        }

        private void GameCircleTimer_Tick(object? sender, EventArgs e)
        {
            var enemy = _enemyModel.CreateEnemy(_arenaStart);
            GameCanvas.Children.Add(enemy);
            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RemoveEnemy(sender);
            AddScore();
        }

        private void MoveTimer_Tick(object? sender, EventArgs e)
        {
            foreach (Shape enemy in GameCanvas.Children.OfType<Shape>())
            {
                double yPosition = (double)enemy.GetValue(Canvas.TopProperty);
                Canvas.SetTop(enemy, yPosition + _enemyModel.Speed);
                StopGame(yPosition);
            }
        }
    }
}