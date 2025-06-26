using System.Diagnostics;

Debug.Assert(Exponentiation(-1, 3) == -1);
Debug.Assert(Exponentiation(-1, 2) == 1);
Debug.Assert(Exponentiation(0, 2) == 0);
Debug.Assert(Exponentiation(1, 1) == 1);
Debug.Assert(Exponentiation(2, 1) == 2);
Debug.Assert(Exponentiation(2, 3) == 8);
Debug.Assert(Exponentiation(3, 3) == 27);
Debug.Assert(Exponentiation(3, -2) == 0.1111111111111111);

double Exponentiation(double basis, int power)
{
    if (power < 0)
        return 1 / Exponentiation(basis, -power); //O(n)

    if (power == 0)
        return 1;

    if (power > 0)
        return basis * Exponentiation(basis, power - 1); //O(n)
    return -1;

}
// итог: O(n)