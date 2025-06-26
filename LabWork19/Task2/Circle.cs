using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Circle : IShape
    {
        public void Draw() 
            => Console.WriteLine("Inside Circle::draw() method.");
    }
}