using System;
using System.Collections.Generic;

namespace L9_6.Generic_Count_Method_Doubles
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
            List<Box<double>> boxes = new List<Box<double>>();

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double value = Convert.ToDouble(Console.ReadLine());

                boxes.Add(new Box<double>(value));
            }

            double element = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CountGreater(boxes, element));
            Console.ReadKey();
        }
    }
}
