int Modulus(int x)
    => x = x < 0 ? -x : x;
int Factorial(int x)
{
    if (x < 0)
        return -1;
    if (x <= 1)
        return 1;
    int result = 1;
    for (int i = 1; i <= x; i++)
        result *= i;
    return result;
}
int Squaring(int x)
    => x * x;

MathDelegate mathDelegate = Modulus;
Console.WriteLine($"Модуль: {mathDelegate(-3)}");

mathDelegate = Factorial;
Console.WriteLine($"Факториал: {mathDelegate(5)}");

mathDelegate = Squaring;
Console.WriteLine($"Возведение в квадрат: {mathDelegate(3)}");

//Task4
MathDelegate[] mathDelegates = [Modulus, Factorial, Squaring];

Console.WriteLine();
foreach (var item in mathDelegates)
    Console.WriteLine($"Возвращаемое значение: {item(-3)}");

//Task5 
Console.WriteLine();
foreach (var item in mathDelegates)
    Math(item, 3);

void Math(MathDelegate math, int x)
{
    Console.WriteLine($"Возвращаемое значение: {math(x)}");
}

delegate int MathDelegate(int x);