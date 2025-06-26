int[] coins = { 1, 3, 4 };
Console.WriteLine("Введите сумму монет");
int.TryParse(Console.ReadLine(), out int sum);
GiveChange(coins, sum);

void GiveChange(int[] coins, int sum)
{
    Array.Sort(coins);
    for (int i = coins.Length - 1; i >= 0; i--)
    {
        while (sum >= 0 && sum >= coins[i])
        {
            sum -= coins[i];
            Console.Write($"{coins[i]} ");
        }
    }
}

