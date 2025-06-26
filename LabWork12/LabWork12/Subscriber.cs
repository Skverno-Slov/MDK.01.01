struct Subscriber
{
    string _fullName;
    string _telephoneNumber;
    int _talkTime;
    public Tariff tariff;

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

    public Tariff Tariff
    {
        get { return tariff; }
        set
        {
            if ((int)value >= 0 && (int)value <= 1)
                tariff = value;
        }
    }

    public Subscriber(string fullName, string telephoneNumber, int talkTime)
    {
        FullName = fullName;
        TelephoneNumber = telephoneNumber;
        TalkTime = talkTime;
        Tariff = Tariff.TimeBased;
    }

    public void Print()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Номер телефона: {TelephoneNumber}");
        Console.WriteLine($"Время разговора: {TalkTime}");
        Console.WriteLine($"Тариф: {Tariff}");
        Console.WriteLine();
    }
}