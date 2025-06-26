int[] numbers = { 10, 2, 30, 4, 5 };
Console.WriteLine(FindLocalMax(numbers));

int FindLocalMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
            return array[i];
    }
    return array[array.Length - 1];
}
