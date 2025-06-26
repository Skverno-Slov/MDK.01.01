using System.Diagnostics;

int[] numbers = { 35, 23, 104, 33, 43, 44 };
int LinearSearch(int[] array, int elementToSearch)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elementToSearch)
            return i;
    }
    return -1;
}
//{35, 23, 104, 33, 43, 44}
Debug.Assert(LinearSearch(numbers, 35) == 0);
Debug.Assert(LinearSearch(numbers, 23) == 1);
Debug.Assert(LinearSearch(numbers, 44) == 5);
Debug.Assert(LinearSearch(numbers, 52) == -1);

