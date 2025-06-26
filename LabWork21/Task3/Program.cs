int[] numbers = { 10, 2, 3, 5 };
FindSum(numbers);
Console.WriteLine(GetDaysCount(10, 2025));
Console.WriteLine(GetDaysCount(2, 2024));

int GetDaysCount(int month, int year)
{
    if (month > 12 && month < 1)
        return -1;
    if (month == 4 || month == 6 || month == 9 || month == 11)
        return 30;
    if (month == 2)
        return (year % 400 == 0 || year % 100 != 0 && year % 4 == 0) ? 29 : 28;
    return 31;
}

void FindSum(int[] numbers)
{
    if (numbers.Length == 0)
        throw new InvalidOperationException("в массиве нет чисел");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
        sum += numbers[i];

    Console.WriteLine($"sum = {sum}");
}