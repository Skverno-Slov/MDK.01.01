class Program
{
    static void Main()
    {
        Subscriber subscriber1 = new();
        subscriber1.Print();
        Subscriber subscriber2 = new("Иванов Иван Иванович", "88005673545", 120);
        subscriber2.Print();
        Console.WriteLine(subscriber2["_fullName"]);
        Console.WriteLine(subscriber2["_telephoneNumber"]);
        Console.WriteLine(subscriber2["_talkTime"]);
        Console.WriteLine(subscriber2[3]);
        Console.WriteLine(Arithmetic.Perimeter(4));
        Console.WriteLine(Arithmetic.Perimeter(4, 5));
        Console.WriteLine(Arithmetic.Exponentation(10, 3));
        Console.WriteLine(Arithmetic.Exponentation(10, -2));
        Console.WriteLine(Arithmetic.Exponentation(10));
    }
}