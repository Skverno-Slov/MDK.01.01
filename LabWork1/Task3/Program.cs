int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };
WriteArray(numbers);
InsertionSort(numbers);

static void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
    Console.WriteLine();
}

void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int selectedElementIndex = i;
        while (selectedElementIndex > 0 && array[selectedElementIndex - 1] > array[selectedElementIndex])
        {
            int temp = array[selectedElementIndex - 1];
            array[selectedElementIndex - 1] = array[selectedElementIndex];
            array[selectedElementIndex] = temp;
            selectedElementIndex--;
            WriteArray(array);
        }

    }
}
