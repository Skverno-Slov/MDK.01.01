Console.WriteLine("Task 1");
Subscriber[] subscribers1 = [
    new() {FullName = "Иванов Иван Иванович", TelephoneNumber = "89009009999", TalkTime = 120},
    new() {FullName = "Сергеев Сергей Сергеевич", TelephoneNumber = "89009009988", TalkTime = 100},
    new() {FullName = "Unknown", TelephoneNumber = "89000000000", TalkTime = 110}
    ];

foreach (var subscriber in subscribers1)
    subscriber.Print();

Console.WriteLine();
Array.Sort(subscribers1);
foreach (var subscriber in subscribers1)
    subscriber.Print();

Subscriber[] subscribers2 = [
    new() {FullName = "Иванов Иван Иванович", TelephoneNumber = "89009009999", TalkTime = 100},
    new() {FullName = "Сергеев Сергей Сергеевич", TelephoneNumber = "89009009988", TalkTime = 130},
    new() {FullName = "Unknown", TelephoneNumber = "89000000000", TalkTime = 110}
    ];

Console.WriteLine("Task 2");
foreach (var subscriber in subscribers2)
    subscriber.Print();

Console.WriteLine();
Array.Sort<Subscriber>(subscribers2);
foreach (var subscriber in subscribers2)
    subscriber.Print();

Console.WriteLine("Taks 3");
Subscriber subscriber1 = new();
subscriber1.FullName = "Иванов Иван Иванович";
subscriber1.TelephoneNumber = "89009111111";
subscriber1.TalkTime = 100;

Subscriber subscriber2 = new();
subscriber2.FullName = "Иванов Иван Иванович";
subscriber2.TelephoneNumber = "89009111111";
subscriber2.TalkTime = 110;

if (subscriber1.Equals(subscriber2))
    Console.WriteLine("Объеты одинаковые");
else Console.WriteLine("Объекты Разные");

Console.WriteLine("Task 4");
subscriber2 = (Subscriber)subscriber1.Clone();
subscriber1.Print();
Console.WriteLine();
subscriber2.Print();

Console.WriteLine("Task 5");
Subscriber[] subscribers3 = [
    new() {FullName = "Иванов Иван Иванович", TelephoneNumber = "89009009999", TalkTime = 1000},
    new() {FullName = "Сергеев Сергей Сергеевич", TelephoneNumber = "89009009988", TalkTime = 24},
    new() {FullName = "Unknown", TelephoneNumber = "89000000000", TalkTime = 0}
    ];
foreach (var subscriber in subscribers3)
    subscriber.Print();
Array.Sort(subscribers3, new DescendingComparer());
Console.WriteLine();
foreach (var subscriber in subscribers3)
    subscriber.Print();

Console.WriteLine();
Subscriber[] subscribers4 = [
    new() {FullName = "Иванов Иван Иванович", TelephoneNumber = "89009009999", TalkTime = 100},
    new() {FullName = "Unknown", TelephoneNumber = "89000000000", TalkTime = 110},
    new() {FullName = "Сергеев Сергей Сергеевич", TelephoneNumber = "89009009988", TalkTime = 130}
    ];
foreach (var subscriber in subscribers4)
    subscriber.Print();
Console.WriteLine();
Array.Sort(subscribers4, new StringComparer());
foreach (var subscriber in subscribers4)
    subscriber.Print();
