using System;
class Lab2p5
{
    static void Main()
    {
        string[] array1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] array2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        char[] arr1 = new char[array1.Length];
        char[] arr2 = new char [array2.Length];
        for (int i = 0; i < array1.Length; ++i)
        {
            arr1[i] = Convert.ToChar(array1[i]);
        }
        for (int i = 0; i < array2.Length; ++i)
        {
            arr2[i] = Convert.ToChar(array2[i]);
        }
        if (arr1[0] < arr2[0])
        {
            foreach(var q in arr1)
            {
                Console.Write($"{q }");
            }
            Console.WriteLine();
            foreach (var q in arr2)
            {
                Console.Write($"{q }");
            }
        }
        else
        {
            foreach (var q in arr2)
            {
                Console.Write($"{q }");
            }
            Console.WriteLine();
            foreach (var q in arr1)
            {
                Console.Write($"{q }");
            }
        }

        Console.ReadKey();
    }
}
