internal class Subscriber
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
        : this("unknown", "89000000000", 0){ }

    public static Subscriber operator ++(Subscriber subscriber)
    {
        return new(subscriber.FullName, subscriber.TelephoneNumber, subscriber.TalkTime + 1);
    }

    public static Subscriber operator +(Subscriber subscriber1, Subscriber subscriber2)
    {
        return new()
        {
            FullName = subscriber1.FullName,
            TelephoneNumber = subscriber1.TelephoneNumber,
            TalkTime = subscriber1.TalkTime + subscriber2.TalkTime
        };
    }

    public static bool operator ==(Subscriber subscriber1, Subscriber subscriber2)
    {
        return subscriber1.FullName == subscriber2.FullName 
            && subscriber1.TelephoneNumber == subscriber2.TelephoneNumber 
            && subscriber1.TalkTime == subscriber2.TalkTime;
    }

    public static bool operator !=(Subscriber subscriber1, Subscriber subscriber2)
    {
        return subscriber1.FullName != subscriber2.FullName
            || subscriber1.TelephoneNumber != subscriber2.TelephoneNumber
            || subscriber1.TalkTime != subscriber2.TalkTime;
    }

    public static bool operator true(Subscriber subscriber)
    {
        return subscriber.TalkTime > 0;
    }

    public static bool operator false(Subscriber subscriber)
    {
        return subscriber.TalkTime <= 0;
    }

    public void Print()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Номер телефона: {TelephoneNumber}");
        Console.WriteLine($"Время разговора: {TalkTime}");
    }
}
