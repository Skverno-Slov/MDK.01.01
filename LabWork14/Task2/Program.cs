// Исходная строка с пробелами
using System.Text.RegularExpressions;

string inputString = "Пример    текста  пример      текста пример  текста";

Regex regex = new(@"\s{2,}");

Console.WriteLine(Regex.Replace(inputString, regex.ToString(), " "));
