using System.Text.RegularExpressions;

Regex regex = new(@"^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!.?,]).{6,}$");
string? password = string.Empty;
while (true)
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();
    if(password.Length == 0)
    {
        Console.WriteLine("Пароль не может быть пустым.");
        continue;
    }

    if (Regex.IsMatch(password, regex.ToString()))
    {
        Console.WriteLine("Пароль надежный.");
        break;
    }
    else
        Console.WriteLine("Пароль должен содержать хотя бы 6 символов, включать строчные буквы, прописные буквы, цифры и знаки препинания (.?!)");
}

