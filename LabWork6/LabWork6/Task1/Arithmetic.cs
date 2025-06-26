internal class Arithmetic
{
    public static double Exponentation(int basis)
    {
        return basis * basis;
    }

    public static double Exponentation(double basis, int power)
    {
        if (power == 0)
            return 1;

        if (power < 0)
            return -1;

        double result = 1;
        for (int i = 0; i < power; i++)
            result *= basis;
        return result;
    }

    public static double Perimeter(double side)
    {
        return side * 4;
    }

    public static double Perimeter(double lenght, double width)
    {
        return (lenght + width) * 2;
    }
}