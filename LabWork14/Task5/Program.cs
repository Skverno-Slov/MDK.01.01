using System.Text.RegularExpressions;

string date1 = "Пример 12.02.2005 asdasda";
string date2 = "23/12/1997";

Regex regex = new(@"\b(\d{1,2})(/|\.)(\d{1,2})(/|\.)(\d{2}|\d{4})\b");

string replacement = "$5-$3-$1";

Console.WriteLine(regex.Replace(date1, replacement));
Console.WriteLine(regex.Replace(date2, replacement));
