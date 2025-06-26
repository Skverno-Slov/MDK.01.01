using LabWork9;

Ellipse ellipse1 = new();
ellipse1.MajorSemiAxe = 10;
ellipse1.MinorSemiAxe = 8;
ellipse1.Print();
Console.WriteLine();

Subscriber subscriber1 = new();
subscriber1.FullName = "Иванов Иван Иванович";
subscriber1.TelephoneNumber = "89009999999";
subscriber1.TalkTime = 1290;
subscriber1.Print();
Console.WriteLine();

Ellipse ellipse2 = new();
ellipse2.MajorSemiAxe = 10;
ellipse2.MinorSemiAxe = 8;
ellipse2.ShowInfo();
Console.WriteLine($"Площадь: {ellipse2.GetSquare()}");
Console.WriteLine($"Периметр: {ellipse2.GetPerimeter()}");
Console.WriteLine();

IPrinter printer1 = new Subscriber();
printer1 = subscriber1;
printer1.Print();
Console.WriteLine();

IPrinter printer2 = new Subscriber();
printer2 = ellipse2;
printer2.Print();
Subscriber subscriber2 = new();
subscriber2.FullName = "Сергей Сергеевич Сергеев";
subscriber2.TelephoneNumber = "89009989898";
subscriber2.TalkTime = 1300;
Console.WriteLine();

IPrinter[] printers = { subscriber1, subscriber2, ellipse1, ellipse2 };
foreach (IPrinter printer in printers)
{
    printer.Print();
    if (printer is IFigure figure)
    {
        Console.WriteLine(figure.Name);
    }
    Console.WriteLine();
}




