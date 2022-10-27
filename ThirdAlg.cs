public static void ShellSort1(int[] Array)
{
    int j;
    int step = Array.Length / 2;
    while (step > 0)
    {
        for (int i = 0; i < (Array.Length - step); i++)
        {
            j = i;
            while ((j >= 0) && (Array[j] > Array[j + step]))
            {
                int tmp = Array[j];
                Array[j] = Array[j + step];
                Array[j + step] = tmp;
                j -= step;
            }
        }
        step = step / 2;
    }
}