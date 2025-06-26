using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

Debug.Assert(Factorial(-2) == -1);
Debug.Assert(Factorial(0) == 1);
Debug.Assert(Factorial(1) == 1);
Debug.Assert(Factorial(6) == 720);

int Factorial(int number)
{
    return number < 0 ?  -1 : number == 0 ? 1 : number * Factorial(number - 1);     //O(n!)
}
//итог: O(n!)
