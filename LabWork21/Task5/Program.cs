Dictionary<int, long> cashe = new();
Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(2));
Console.WriteLine(Factorial(4));
long Factorial(int number)
{
    if (cashe.ContainsKey(number))
        return cashe[number];
    if (number < 0)
        return -1;
    if (number == 0 || number == 1)
        return 1;
    long result = number * Factorial(number - 1);
    cashe.Add(number, result);
    return result;
}

double FastExponentiation(double basis, int power)
{
    return power < 0 ?
        -1 : power == 0 ?
        1 : power % 2 == 0 ?
        FastExponentiation(basis * basis, power / 2) :
        basis * FastExponentiation(basis * basis, (power - 1) / 2);
}
