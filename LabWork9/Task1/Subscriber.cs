using LabWork9;

class Subscriber : IPrinter
{
    public string FullName { get; set; }
    public string TelephoneNumber { get; set; }
    public double TalkTime { get; set; }

    public void Print()
    {
        Console.WriteLine($"Полное имя:{FullName}\nНомер телефона:{TelephoneNumber}\nВремя разговора:{TalkTime}" );
    }
}