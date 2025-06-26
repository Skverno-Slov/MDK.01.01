Console.Write("Введите стороку (на английском): ");
string? text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    char[] sentenceEndings = { ',', '-', ':', ';' };

    string[] sentences = text.Split(sentenceEndings,
        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine("Результат:");
    foreach (var sentence in sentences)
        Console.WriteLine(sentence);
}
else
    Console.WriteLine("Некорректон введена строка");