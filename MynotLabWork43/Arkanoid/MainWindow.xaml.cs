using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Arkanoid
{
    public partial class GameWindow : Window
    {
        private DispatcherTimer _gameFrameTimer = new(DispatcherPriority.Render);
        private Random _random = new();
        private Ellipse _ball;

        private int _racketSpeed = 10;
        private int _ballSpeedX = -2;
        private int _ballSpeedY = -2;

        public GameWindow()
        {
            InitializeComponent();

            _gameFrameTimer.Interval = TimeSpan.FromMilliseconds(15);
            _gameFrameTimer.Tick += GameFrameTimer_Tick;
            _gameFrameTimer.Start();

            SpawnBall();
        }

        private void GameFrameTimer_Tick(object? sender, EventArgs e)
        {
            MoveBall(); 
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MoveRacket(e);
        }

        private void SpawnBall()
        {
            _ball = new Ellipse()
            {
                Width = 20,
                Height = 20,
                Fill = new SolidColorBrush(Colors.White),
                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 2,
            };

            GameCanvas.Children.Add(_ball);

            Canvas.SetLeft(_ball, _random.Next(200, 500));
            Canvas.SetTop(_ball, _random.Next(400, 600));
        }

        private void MoveBall()
        {
            var topBorder = Canvas.GetTop(_ball);
            var bottomBorder = Canvas.GetTop(_ball) + _ball.Height;
            var leftBorder = Canvas.GetLeft(_ball);
            var rightBorder = Canvas.GetLeft(_ball) + _ball.Width;

            if (topBorder < 0 || (bottomBorder > Canvas.GetTop(RacketRectangle) 
                && leftBorder > Canvas.GetLeft(RacketRectangle) 
                && rightBorder < Canvas.GetLeft(RacketRectangle) + RacketRectangle.Width)) 
            {
                _ballSpeedY = -_ballSpeedY;
            }
            if (leftBorder < 0 || rightBorder > 670)
            {
                _ballSpeedX = -_ballSpeedX;
            }

            if (bottomBorder > 640)
            {
                _gameFrameTimer.Stop();
                MessageBox.Show("Игра окончена");
            }

            Canvas.SetTop(_ball, topBorder + _ballSpeedY);
            Canvas.SetLeft(_ball, leftBorder + _ballSpeedX);
        }

        private void MoveRacket(KeyEventArgs e)
        {
            var leftborder = Canvas.GetLeft(RacketRectangle);
            var rightborder = Canvas.GetLeft(RacketRectangle) + RacketRectangle.Width;

            if (leftborder > 0 && e.Key == Key.A)
            {
                Canvas.SetLeft(RacketRectangle, Canvas.GetLeft(RacketRectangle) - _racketSpeed);
            }
            if (rightborder < 670 && e.Key == Key.D)
            {
                Canvas.SetLeft(RacketRectangle, Canvas.GetLeft(RacketRectangle) + _racketSpeed);
            }
        }
    }
}