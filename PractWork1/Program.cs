Console.WriteLine("Введите имя файла:");
string? fileName = Console.ReadLine();
if (File.Exists(fileName))
    Console.WriteLine(File.ReadAllText(fileName));
else
    Console.WriteLine("Файл не существует.");