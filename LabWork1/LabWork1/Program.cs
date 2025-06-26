int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

WriteArray(numbers);
SelectionSort(numbers);

static void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minElementIndex = i;

        for (int j = i + 1; j < array.Length ; j++)
            if (array[j] < array[minElementIndex])
                minElementIndex = j;

        if (minElementIndex != i)
        {
            int temp = array[i];
            array[i] = minElementIndex;
            array[minElementIndex] = temp;
        }
        WriteArray(array);
    }
}