using System.Text.RegularExpressions;

Regex regex = new(@"^[-_\w.]+@([A-Z0-9][-A-Z0-9]+\.)+[A-Z]{2,4}$");
Console.Write("Введите e-mail адрес: ");
string? email = Console.ReadLine();

if (Regex.IsMatch(email, regex.ToString(), RegexOptions.IgnoreCase))
    Console.WriteLine("E-mail адрес корректный.");
else
    Console.WriteLine("E-mail адрес некорректный.");