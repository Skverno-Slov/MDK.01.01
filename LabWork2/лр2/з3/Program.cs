using System.Diagnostics;

int[] numbers = { 12, 23, 32, 33, 43, 44 };
// Тесты {12, 23, 32, 33, 43, 44}
Debug.Assert(JumpSearch(numbers, 12) == 0);
Debug.Assert(JumpSearch(numbers, 23) == 1);
Debug.Assert(JumpSearch(numbers, 32) == 2);
Debug.Assert(JumpSearch(numbers, 33) == 3);
Debug.Assert(JumpSearch(numbers, 44) == 5);
Debug.Assert(JumpSearch(numbers, 52) == -1);

int JumpSearch(int[] array, int elementToSearch)
{
    int previousStep = 0;
    int jumpStep = (int)Math.Sqrt(array.Length);
    int nextStep = jumpStep;

    while (array[nextStep] < elementToSearch)
    {
        previousStep = nextStep;
        nextStep += jumpStep;
        if (nextStep >= array.Length)
        {
            nextStep = array.Length - 1;
            break;
        }
    }
    for (int i = previousStep; i <= nextStep; i++)
    {
        if (array[i] == elementToSearch)
            return i;
    }
    return -1;
}