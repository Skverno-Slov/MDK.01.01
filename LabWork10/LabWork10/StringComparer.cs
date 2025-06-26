internal class StringComparer : IComparer<Subscriber>
{
    public int Compare(Subscriber? subscriber1, Subscriber? subscriber2)
    {
        return subscriber1.FullName.CompareTo(subscriber2?.FullName);
    }
}

