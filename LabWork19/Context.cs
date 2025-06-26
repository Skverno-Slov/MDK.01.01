public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public int ExecuteStrategy(int number1, int number2)
    {
        return _strategy.DoOperation(number1, number2);
    }
}
