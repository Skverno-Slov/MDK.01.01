List<string> fish = new() { "килька", "барабулька", "сардина" };
//Console.WriteLine("Введте сколько элементов добавить:");
//uint.TryParse(Console.ReadLine(), out uint countFish);
//Console.WriteLine("Введите элементы:");
//for (int i = 0; i < countFish; i++)
//    fish.Add(Console.ReadLine());
//for (int i = 0; i < fish.Count; i++)
//    Console.WriteLine($"{i + 1} - {fish[i]}");
//Console.WriteLine($"Элементов в списке: {fish.Count}");

//Dictionary<uint, string> workers = new();
//workers[1] = "Иванов Иван Иванович";
//workers[4] = "Алексеев Алексей Алексеевич";
//workers[3] = "Максим Максим Максимович";
//Console.WriteLine("Введте сколько элементов добавить:");
//uint.TryParse(Console.ReadLine(), out uint countWorkers);
//for (int i = 0; i < countWorkers; i++)
//{
//    Console.WriteLine("Введите ключ");
//    uint.TryParse(Console.ReadLine(), out uint key);
//    Console.WriteLine("Введите ФИО");
//    string fullName = Console.ReadLine();
//    if (!workers.TryAdd(key, fullName))
//        Console.WriteLine("Ключ занят");
//}
//Console.WriteLine();
//foreach (var worker in workers)
//    Console.WriteLine($"{worker.Key} - {worker.Value}");
//Console.WriteLine($"Элементов в словаре: {workers.Count}");

//Console.WriteLine();
//Console.WriteLine("Введите ключ для поиска");
//uint.TryParse(Console.ReadLine(), out uint SearchingKey);
//if (workers.ContainsKey(SearchingKey))
//    Console.WriteLine($"По этому ключу найден работник: {workers[SearchingKey]}");
//else
//    Console.WriteLine("Работников не найдено");

//Console.WriteLine();
//Console.WriteLine("Введите ФИО Работника");
//string SearchingFullName = Console.ReadLine();
//int workersFinded = 0;
//foreach (var value in workers.Values)
//    if (SearchingFullName == value)
//        workersFinded++;
//Console.WriteLine($"Рабочих с таким ФИО в коллекции: {workersFinded}");

//Console.WriteLine();
//Console.WriteLine("Введите ключ для удаления");
//uint.TryParse(Console.ReadLine(), out uint keyToRemove);
//if (workers.ContainsKey(keyToRemove))
//{
//    Console.WriteLine($"Работник {workers[keyToRemove]} удален");
//    workers.Remove(keyToRemove);
//}
//else
//    Console.WriteLine("Ключ не найден");

//Console.WriteLine();
string lastElement = fish[fish.Count - 1];
fish.RemoveAt(fish.Count - 1);
fish.Insert(0, lastElement);

foreach (var oneFish in fish)
    Console.WriteLine(oneFish);