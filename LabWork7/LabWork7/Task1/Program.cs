Subscriber subscriber1 = new();
subscriber1.Print();
subscriber1++;
subscriber1.Print();
Subscriber subscriber2 = new("Иванов Иван Иванович", "89005464565", 100);
subscriber2.Print();
Subscriber subscriber3 = new();
subscriber3.TalkTime = 50;
subscriber3.Print();
Subscriber subscriber4 = subscriber2 + subscriber3;
subscriber4.Print();
Subscriber subscriber5 = new();
subscriber5.FullName = "Test";
Subscriber subscriber6 = new();
subscriber6.FullName = "Test";
Subscriber subscriber7 = new("Test", "89009009090", 142);
subscriber7.Print();
if (subscriber5 == subscriber6)
    Console.WriteLine("Абоненты одинаковы");
else 
    Console.WriteLine("Абоненты разные");
if (subscriber5 != subscriber6)
    Console.WriteLine("Абоненты разные");
else
    Console.WriteLine("Абоненты одинаковы");
if (subscriber7)
    Console.WriteLine("subscriber.TalkTime > 0");
else
    Console.WriteLine("subscriber.TalkTime <= 0");
