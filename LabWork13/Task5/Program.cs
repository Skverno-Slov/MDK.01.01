string[] strings = {
            "Легенда 42",
            "Venom",
            "Rock and stone",
            "Легенда Затона",
        };

Console.Write("Введите текст для поиска: ");
string? text = Console.ReadLine();

bool isFinded = false;
foreach (string item in strings)
    if (item.Contains(text))
    {
        isFinded = true;
        Console.WriteLine(item);
    }

if (!isFinded)
    Console.WriteLine("Совпадения не найдены.");
