class Square : Figure
{
    public double Side { get; set; } = 1;
    public override string Name { get => "Квадрат"; }

    public override double GetSquare()
        => Side * Side;

    public override double GetPerimeter()
        => Side * 4;

    public override void ShowInfo()
    {
        Console.WriteLine($"Сторона: {Side}");
    }
}