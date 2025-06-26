void Sum(int x, int y)
    => Console.WriteLine($"Сумма: {x + y}");
void Difference(int x, int y)
    => Console.WriteLine($"Разность: {x - y}");
void Product(int x, int y)
    => Console.WriteLine($"Произведение: {x * y}");
void Quotient(int x, int y)
    => Console.WriteLine($"Чаcтное: {(double)x / (double)y}");

MathDelegate math = Sum;
math += Difference;
math += Product;
math += Quotient;
math(10, 5);

delegate void MathDelegate(int x, int y);
