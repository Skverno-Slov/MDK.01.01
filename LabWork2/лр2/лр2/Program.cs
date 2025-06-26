using System.Diagnostics;

int[] numbers = { 12, 23, 32, 33, 43, 44 };

//{ 12, 23, 32, 33, 43, 44 }
Debug.Assert(BinarySearch(numbers, 12) == 0);
Debug.Assert(BinarySearch(numbers, 23) == 1);
Debug.Assert(BinarySearch(numbers, 44) == 5);
Debug.Assert(BinarySearch(numbers, 52) == -1);

int BinarySearch(int[] array, int elementToSearch)
{
    Array.Sort(array);
    int left = 0;
    int right = array.Length - 1;
    do
    {
        int middle = (left + right) / 2;
        if (elementToSearch ==  array[middle])
            return middle;
        if (elementToSearch < array[middle])
            right = middle - 1;
        else
            left = middle + 1;
    } while (left <= right);
    return -1;
}