using LabWork9;

internal class Ellipse : IPrinter, IFigure
{
    public string Name => "Элипс";
    public double MajorSemiAxe { get; set; }
    public double MinorSemiAxe { get; set; }

    public double GetPerimeter() => Math.PI * (MajorSemiAxe + MinorSemiAxe);

    public double GetSquare() => Math.PI * MajorSemiAxe * MinorSemiAxe;

    public void Print()
        => Console.WriteLine($"Большая полуось:{MajorSemiAxe}\nМалая полуось:{MinorSemiAxe}");

    public void ShowInfo()
        => Console.WriteLine($"Название: {Name}\nБольшая полуось:{MajorSemiAxe}\nМалая полуось:{MinorSemiAxe}");
}

