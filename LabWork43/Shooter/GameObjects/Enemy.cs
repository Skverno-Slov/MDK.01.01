using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Shooter
{
    class Enemy
    {
        private double _speed;
        private static int _width;
        private static int _height;

        public double Speed
        {
            get => _speed;
        }

        public Enemy(double speed,
                     int width,
                     int height)
        {
            _speed = speed;
            _width = width ;
            _height = height;
        }
        public Enemy(double speed) 
        {
            _speed = speed;
            _width = 30;
            _height = 30;
        }

        public Enemy()
        {
            _speed = 3;
            _width = 30;
            _height = 30;
        }

        public Ellipse? CreateEnemy(double windowWidth)
        {
            Ellipse enemyModel = new() 
            {
                Width = _width,
                Height = _height,
                Fill = new SolidColorBrush(Colors.Red)
            };
            double x = new Random().NextDouble() * (windowWidth - _width);
            Canvas.SetLeft(enemyModel, x);
            Canvas.SetTop(enemyModel, -enemyModel.Height);
            return enemyModel;
        }
    }
}
