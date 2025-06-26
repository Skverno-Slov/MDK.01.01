using System.Text.RegularExpressions;

Regex regex = new(@"^(\+7\((9\d{2})\)\d{3}-\d{2}-\d{2}|8\((9\d{2})\)\d{3}-\d{2}-\d{2})$");

Console.Write("Введите номер телефона: ");
string? phoneNumber = Console.ReadLine();

// Проверка номера телефона
if (Regex.IsMatch(phoneNumber, regex.ToString()))
    Console.WriteLine("Номер телефона корректный.");
else
    Console.WriteLine("Номер телефона некорректный.");
