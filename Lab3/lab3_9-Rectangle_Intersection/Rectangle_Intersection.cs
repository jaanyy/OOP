using System;
using System.Collections.Generic;

namespace lab3_9_Rectangle_Intersection
{
    class Rectangle_Intersection
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                rectangles.Add(new Rectangle(info[0], Convert.ToInt32(info[1]), Convert.ToInt32(info[2]), Convert.ToInt32(info[3]), Convert.ToInt32(info[4])));
            }

            for (int i = 0; i < m; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                Rectangle first = rectangles[0], second = rectangles[0];

                Console.WriteLine(first.CheckIntersection(second));
            }
            Console.ReadKey();
        }
    }
}
