using System.Diagnostics;

Console.WriteLine(FastExponentiation(2, 10));

Console.WriteLine();

Debug.Assert(FastExponentiation(1, -2) == -1);
Debug.Assert(FastExponentiation(0, 2) == 0);
Debug.Assert(FastExponentiation(1, 1) == 1);
Debug.Assert(FastExponentiation(2, 1) == 2);
Debug.Assert(FastExponentiation(2, 3) == 8);
Debug.Assert(FastExponentiation(3, 15) == 14348907);


static double FastExponentiation(double basis, int power)
{
    Console.WriteLine(power);
    return power < 0 ?
        -1 : power == 0 ?
        1 : power % 2 == 0 ?
        FastExponentiation(basis * basis, power / 2) : 
        basis * FastExponentiation(basis * basis, (power - 1) / 2);
}
