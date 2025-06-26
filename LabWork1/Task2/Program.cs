int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

static void WriteArray(int[] array)
{
    for (int k = 0; k < array.Length; k++)
        Console.Write($"{array[k]}\t");
    Console.WriteLine();
}
WriteArray(numbers);
BubbleSort(numbers);

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 1; j < array.Length; j++)
        {
            if (array[j - 1] > array[j])
            {
                int temp = array[j];
                array[j] = array[j - 1];
                array[j - 1] = temp;
            }
        }
        WriteArray(array);
    }
}
