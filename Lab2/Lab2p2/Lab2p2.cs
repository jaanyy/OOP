using System;
class Lab2p1
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int k = 0, i = 0;
        k = Convert.ToInt32(Console.ReadLine());
        int[] new_array = new int[array.Length];
        
        foreach (var q in  array)
        {
            
            new_array[i] = Convert.ToInt32(q);
            ++i;
        }
        
        int[] sum = new int[new_array.Length];
        int z = 0;
        while (z < k)
        {
            var temp = new_array[new_array.Length-1];
            for (var j = new_array.Length-1; j > 0; j--)
            {
                new_array[j] = new_array[j-1];
            }
            new_array[0] = temp;
            int y = 0;
            foreach (int e in new_array)
            {
                sum[y] += e;
                ++y;
            }
            Console.WriteLine();
            ++z;
        }
        foreach(var r in sum)
        {
            Console.Write($"{r} ");
        }

        

        



        Console.ReadKey();
    }
}
