using System.Text.RegularExpressions;

string input = "Сегодня 12.05.2023 и 1/06/23, а завтра будет 31.12.2022.";

// Регулярное выражение для поиска дат
string pattern = @"(?<day>\d{1,2})[./](?<month>\d{1,2})[./](?<year>\d{2}|\d{4})";

// Замена дат на нужный формат
string result = Regex.Replace(input, pattern, match =>
{
    // Получаем значения из именованных групп
    string day = match.Groups["day"].Value.PadLeft(2, '0'); // Добавляем ведущий ноль, если нужно
    string month = match.Groups["month"].Value.PadLeft(2, '0'); // Добавляем ведущий ноль
    string year = match.Groups["year"].Value.Length == 2
        ? "20" + match.Groups["year"].Value // Преобразование двухзначного года в четырехзначный
        : match.Groups["year"].Value;

    // Возвращаем строку в нужном формате
    return $"{year}-{month}-{day}";
});

Console.WriteLine(result);

//(?< day >\d{1,2}) — именованная группа day, которая соответствует дню. Доступны 1 или 2 цифры.
//[./] — символ - разделитель, который может быть либо точкой, либо косой чертой.
//(?<month>\d{1,2}) — именованная группа month, которая соответствует месяцу. Также 1 или 2 цифры.
//[./] — еще один символ-разделитель.
//(?<year>\d{2}|\d{4}) — именованная группа year, которая соответствует году. Может содержать либо 2, либо 4 цифры.
