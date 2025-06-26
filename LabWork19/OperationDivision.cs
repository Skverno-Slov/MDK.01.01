public class OperationDivision : IStrategy
{
    public int DoOperation(int number1, int number2)
    {
        return number2 != 0 ? number1 / number2 : 0;
    }
}
