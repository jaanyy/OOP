using System;
using System.Numerics;

class Lab2p3
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] new_array = new int[array.Length];
        int i = 0, k = array.Length/4;
        foreach (var q in array)
        {
            new_array[i] = Convert.ToInt32(q);
            ++i;
        }
        int tem = new_array.Length / 2;
        int[] row1 = new int[tem];
        int[] row2 = new int[tem];
        int[] sum = new int[tem];
        int z = 0;
        for (int j = k-1; j >= 0; --j)
        {
            row1[z] = new_array[j];
            //Console.Write(row1[z]);
            ++z;
            
        }
        for (int j = new_array.Length-1; j >= new_array.Length-k; --j)
        {
            row1[z] = new_array[j];
            //Console.Write(row1[z]);
            ++z;
        }
        z = 0;
        Console.WriteLine();
        for (int j = k; j < new_array.Length-k; ++j)
        {
            row2[z] = new_array[j];
            //Console.Write(row2[z]);
            ++z;
        }
        Console.WriteLine();

        for (int j = 0; j < tem; ++j)
        {
            sum[j] = row2[j] + row1[j];
        }
        /*foreach (var q in row1)
        {
            Console.Write($"{q} ");
        }
        Console.WriteLine();
        foreach (var q in row2)
        {
            Console.Write($"{q} ");
        }*/
        Console.WriteLine();
        foreach (var q in sum)
        {
            Console.Write($"{q} ");
        }
        


        Console.ReadKey();
    }
}
