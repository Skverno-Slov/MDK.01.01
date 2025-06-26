using System.Text;

Console.Write("Введите стороку (на английском): ");
string? text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    text = text.Trim();

    while (text.Contains("  "))
        text = text.Replace("  ", " ");

    Console.WriteLine($"Результат: {text}");

    Console.WriteLine();
    Console.WriteLine("Выберите способ изменения регистра:");
    Console.WriteLine("1 - Верхний регист");
    Console.WriteLine("2 - Нижний регист");
    Console.WriteLine("3 - Инвертированный");
    Console.Write("Введите номер варианта: ");
    char variant = Console.ReadKey().KeyChar;
    Console.WriteLine();

    StringBuilder builder = new();

    switch (variant)
    {
        case '1':
            builder.Append(text.ToUpper());
            break;
        case '2':
            builder.Append(text.ToLower());
            break;
        case '3':
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (char.IsUpper(currentChar))
                    currentChar = char.ToLower(currentChar);
                else if (char.IsLower(currentChar))
                    currentChar = char.ToUpper(currentChar);
                builder.Append(currentChar);
            }
            break;
        default:
            Console.WriteLine("Некорректный вариант.");
            return;
    }
    Console.WriteLine($"Результат: {builder}");
}
else
    Console.WriteLine("Некорректон введена строка");
