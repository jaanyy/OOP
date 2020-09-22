using System;
class Lab2p10
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[array.Length];
        int z = 0, k = 0, count = 0;
        k = Convert.ToInt32( Console.ReadLine());
        foreach (var q in array)
        {
            num[z] = Convert.ToInt32(q);
            ++z;
        }
        for (int i = 0; i < num.Length; ++i)
        {
            for (int j = 0; j < num.Length; ++j)
            {
                if (Math.Abs(num[i] - num[j]) == k)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count / 2);
        Console.ReadKey();
    }
}
