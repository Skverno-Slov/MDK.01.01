Subscriber subscriber1 = new();
subscriber1.ToString();
Subscriber subscriber2 = new("Иванов Иван Иванович", "89009999999", 120);
Subscriber subscriber3 = new("Иванов Иван Иванович", "89009999999", 120);
if (subscriber2.Equals(subscriber3))
    Console.WriteLine("Абоненты одинаковы");
else
    Console.WriteLine("Абоненты не одинаковы");
Console.WriteLine();
Square square = new();
square.Side = 5;
Console.WriteLine($"Площадь: {square.GetSquare()}");
Console.WriteLine($"Периметр: {square.GetPerimeter()}");
Console.WriteLine();
square.ShowInfo();
Console.WriteLine();
PowerfullRandom random = new PowerfullRandom();
int[] randomArray = random.GetRandomArray(10);
for (int i = 0; i < randomArray.Length; i++)
    Console.Write($"{randomArray[i]} ");