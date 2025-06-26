Subscriber subscriber1 = new()
{
    FullName = "Ивановым Иваном Ивановичем",
    TelephoneNumber = "89009999999",
    TalkTime = 120,
    Tariff = Tariff.Unlimited
};

Subscriber subscriber2 = new();

Subscriber subscriber3 = new("Иванов Иван Иванович", "89009009090", 120);

subscriber1.Print();
Console.WriteLine();
subscriber2.Print();
Console.WriteLine();
subscriber3.Print();
Console.WriteLine();

Subscriber[] subscribers = [
    subscriber1,
    subscriber2,
    new()
        {
        FullName = "Сергеев Сергей Сергеевич",
        TelephoneNumber = "89009900999",
        TalkTime = 100,
        Tariff = Tariff.Unlimited
        },
    new()
    ];

Console.WriteLine("Абоненты с безлимитным тарифом:");
foreach (Subscriber subscriber in subscribers)
{
    if (subscriber.Tariff == Tariff.Unlimited)
        subscriber.Print();
}

Student student1 = new()
{
    fullName = "Иванов Иван Иванович",
    specialization = "Инженер",
    course = 3
};
Student student2 = new()
{
    fullName = "Иванов Иван Иванович",
    specialization = "Инженер",
    course = 3
};
Student student3 = new()
{
    fullName = "Сергеевич Сергей Сергеев",
    specialization = "Банкир",
    course = 2
};

Console.WriteLine(student1);
Console.WriteLine(student2);
Console.WriteLine(student3);

Console.WriteLine();
if (student1.Equals(student2))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные");
if (student2.Equals(student3))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные");
if (student3.Equals(student1))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные");