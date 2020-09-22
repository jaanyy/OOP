using System;
class Lab2p8
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[array.Length];
        int i = 0;
        foreach (var q in array)
        {
            numbers[i] = Convert.ToInt32(q);
            ++i;
        }
        int num = numbers[0], frequent = 1, bestNum = num, bestFrequent = frequent;
        for (int j = 0; j < numbers.Length; ++j)
        {
            num = numbers[j]; frequent = 1;
            for (int z = 0; z < numbers.Length; ++z)
            {
                if(numbers[z] == numbers[j])
                {
                    frequent++;
                }
            }
            frequent--;
            if (frequent > bestFrequent)
            {
                bestFrequent = frequent;
                bestNum = num;
            }
            
        }
        Console.WriteLine(bestNum);
        Console.ReadKey();
    }
}
