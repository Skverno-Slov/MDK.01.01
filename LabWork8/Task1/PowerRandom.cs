internal class PowerfullRandom : Random
{
    public int[] GetRandomArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
            array[i] = base.Next(-100, 100);
        return array;
    }
}