internal class DescendingComparer : IComparer<Subscriber>
{
    public int Compare(Subscriber? subscriber1, Subscriber? subscriber2)
    {
        return -subscriber1.TalkTime.CompareTo(subscriber2?.TalkTime);
    }
}