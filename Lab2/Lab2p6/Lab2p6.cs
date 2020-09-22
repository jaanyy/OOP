using System;
class Lab2p6
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[array.Length];
        int i = 0, start = 0, len = 1, bestStart = 0, bestLen = 1;
        foreach (var q in array)
        {
            numbers[i] = Convert.ToInt32(q);
            ++i;
        }
        for (int j = 1; j < numbers.Length; ++j)
        {
            if (numbers[j] == numbers[j - 1])
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }

            }
            else
            {
                start = j;
                len = 1;
            }
        }
        //Console.Write($"{bestLen} - {bestStart}");
        for (int j = bestStart; j < bestStart+bestLen; ++j)
        {
            Console.Write($"{numbers[j]} ");
        }

        Console.ReadKey();
    }
}
