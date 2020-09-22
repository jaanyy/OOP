using System;
class Lab2p11
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[array.Length];
        int z = 0, left_sum = 0, right_sum = 0;
        bool isExist = false;
        foreach (var q in array)
        {
            num[z] = Convert.ToInt32(q);
            ++z;
        }
        if (num.Length == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            for (int i = 0; i < num.Length; ++i)
            {
                left_sum = right_sum = 0;
                if (i != 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        left_sum += num[j];
                    }
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        right_sum += num[j];
                    }
                    if (left_sum == right_sum)
                    {
                        Console.WriteLine(i);
                        isExist = true;
                        break;
                    }
                }

            }
            if (!isExist) Console.WriteLine("no");
        }
        
        Console.ReadKey();
    }
}
