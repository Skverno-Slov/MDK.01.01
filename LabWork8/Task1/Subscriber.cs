class Subscriber
{
    public string FullName { get; set; }
    public string TelephoneNumber { get; set; }
    public double TalkTime { get; set; }

    public Subscriber(string fullName, string telephoneNumber, double talkTime)
    {
        FullName = fullName;
        TelephoneNumber = telephoneNumber;
        TalkTime = talkTime;
    }

    public Subscriber()
        : this("unknown", "89000000000", 0)
    { }

    public override string ToString()
    {
        return $"{FullName}, телефон: {TelephoneNumber}, время разговора: {TalkTime}";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        return obj is Subscriber subscriber &&
            FullName == subscriber.FullName &&
            TelephoneNumber == subscriber.TelephoneNumber &&
            TalkTime == subscriber.TalkTime;
    }

    public void Print()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Номер телефона: {TelephoneNumber}");
        Console.WriteLine($"Время разговора: {TalkTime}");
    }
}

