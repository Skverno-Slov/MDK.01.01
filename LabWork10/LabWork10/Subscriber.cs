internal class Subscriber : DescendingComparer, IComparable, IComparable<Subscriber>, IEquatable<Subscriber>, ICloneable, IComparer<Subscriber>
{
    public string FullName { get; set; }
    public string TelephoneNumber { get; set; }
    public double TalkTime { get; set; }

    public object Clone()
    {
        return new Subscriber()
        {
            FullName = FullName,
            TelephoneNumber = TelephoneNumber,
            TalkTime = TalkTime
        };
    }

    public int CompareTo(object? obj)
    {
        var subscriber = obj as Subscriber;
        if (obj is Subscriber)
            return TalkTime.CompareTo(subscriber?.TalkTime);
        throw new ArgumentException();
    }

    public int CompareTo(Subscriber? other)
    {
        if (TalkTime > other?.TalkTime)
            return 1;
        if (TalkTime < other?.TalkTime)
            return -1;
        return 0;
    }

    public bool Equals(Subscriber? other)
    {
        return FullName == other?.FullName
            && TelephoneNumber == other?.TelephoneNumber
            && TalkTime == other?.TalkTime;
    }

    public void Print()
    {
        Console.WriteLine($"Полное имя:{FullName}\nНомер телефона:{TelephoneNumber}\nВремя разговора:{TalkTime}");
    }
}

