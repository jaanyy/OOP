using System;
using System.Collections.Generic;

namespace L9_5.Generic_Count_Method_Strings
{
    class Program
    {
        static int CountGreater<T>(IEnumerable<Box<T>> collection, T element)
        where T : IComparable<T>
        {
            int counter = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string value = Console.ReadLine();

                boxes.Add(new Box<string>(value));
            }

            string element = Console.ReadLine();

            Console.WriteLine(CountGreater(boxes, element));

            Console.ReadKey();
        }
    }
}
