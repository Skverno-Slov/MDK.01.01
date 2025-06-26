double r1 = 10;
double r2 = 5;

double s = Math.PI * (r1 - r2) * (r1 + r2);
if (s < 0)
    s = -s;
Console.WriteLine(s);

int n = 10;
int sum = (1 + n) * n / 2;
Console.WriteLine(sum);

Console.WriteLine(GetSize(2156576000));

string GetSize(long bytes)
{
    return bytes < 1 << 10 ? $"{bytes} Б"
        : bytes < 1 << 20 ? $"{bytes >> 10} КБ"
        : bytes < 1 << 30 ? $"{bytes >> 20} МБ"
        : $"{bytes >> 30} ГБ";
}