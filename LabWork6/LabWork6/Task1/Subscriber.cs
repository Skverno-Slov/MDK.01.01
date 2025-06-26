
internal class Subscriber
{
    private string _fullName;
    private string _telephoneNumber;
    private int _talkTime;

    public object? this[string index]
    {
        get
        {
            switch (index)
            {
                case "_fullName":
                    return _fullName;
                case "_telephoneNumber":
                    return _telephoneNumber;
                case "_talkTime":
                    return _talkTime;
                default:
                    return null;
            }
        }
    }

    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < _fullName.Length)
            {
                return _fullName[index];
            }
            return '\0';
        }
    }

    public Subscriber(string fullName, string telephoneNumber, int talkTime)
    {
        _fullName = fullName;
        _telephoneNumber = telephoneNumber;
        _talkTime = talkTime;
    }

    public Subscriber()
        : this("Unknown", "89000000000", 0)
    { }

    public void Print()
    {
        Console.WriteLine($"ФИО: {_fullName}");
        Console.WriteLine($"Номер телефона: {_telephoneNumber}");
        Console.WriteLine($"Время разговора: {_talkTime}");
    }
}
