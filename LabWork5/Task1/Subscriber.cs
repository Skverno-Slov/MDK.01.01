internal class Subscriber
{
    string _fullName;
    string _telephoneNumber;
    int _talkTime;

    public string FullName
    {
        get { return _fullName; }
        set
        {
            if (value.Trim() != "")
                _fullName = value.Trim();
        }
    }

    public string TelephoneNumber
    {
        get { return _telephoneNumber; }
        set
        {
            if (value.Length == 11)
                _telephoneNumber = value;
        }
    }

    public int TalkTime
    {
        get { return _talkTime; }
        set
        {
            if (value > 0)
                _talkTime = value;
        }
    }

    public Subscriber(string fullName, string telephoneNumber, int talkTime)
    {
        FullName = fullName;
        TelephoneNumber = telephoneNumber;
        TalkTime = talkTime;
    }

    public Subscriber()
        : this("Unknown", "89000000000", 0) { }

    public void Print()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Номер телефона: {TelephoneNumber}");
        Console.WriteLine($"Время разговора: {TalkTime}");
        Console.WriteLine();
    }
}
