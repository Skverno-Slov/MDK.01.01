Console.Write("Введите стороку (на английском): ");
string? text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    Console.WriteLine($"Символов в стороке: {text.Length}");

    Console.WriteLine($"Симвлов в стороке без пробелов: {text.Replace(" ", "").Length}");

    int lettersCounter = 0;
    for (int i = 0; i < text.Length; i++)
        if (char.IsAsciiLetter(text[i]))
            lettersCounter++;
    Console.WriteLine($"Букв в сторке: {lettersCounter}");

    Console.Write("Введите один символ: ");
    char searchChar = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (!char.IsWhiteSpace(searchChar))
    {
        for (int i = 0; i < text.Length; i++)
            if (text[i] == searchChar)
                Console.WriteLine(i);
        if (!text.Contains(searchChar))       
            Console.WriteLine("Символ не найден");
    }
    else
        Console.WriteLine("Некорректоно введён символ");
}
else
    Console.WriteLine("Некорректон введена строка");
