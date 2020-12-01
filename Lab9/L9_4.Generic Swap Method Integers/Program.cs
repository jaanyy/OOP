using System;
using System.Collections.Generic;
using System.Linq;

namespace L9_4.Generic_Swap_Method_Integers
{
    class Program
    {
        static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        static void Main(string[] args)
        {
            var boxes = new List<Box<int>>();

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                boxes.Add(new Box<int>(value));
            }

            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxes, indices[0], indices[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }

            Console.ReadKey();
        }
    }
}
