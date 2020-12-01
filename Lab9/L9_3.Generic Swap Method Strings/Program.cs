using System;
using System.Collections.Generic;
using System.Linq;

namespace L9_3.Generic_Swap_Method_Strings
{
    class Program
    {
        static void Swap<T>(List<Box<T>> list, int ind1, int ind2)
        {
            Box<T> temp = list[ind1];
            list[ind1] = list[ind2];
            list[ind2] = temp;
        }

        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                boxes.Add(new Box<string>(value));
            }

            int[] r = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxes, r[0], r[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }

            Console.ReadKey();
        }
    }
}
