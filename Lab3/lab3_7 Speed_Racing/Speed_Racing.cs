using System;
using System.Collections.Generic;

namespace lab3_7_Speed_Racing
{
    class Speed_Racing
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                cars.Add(new Car(input[0], Convert.ToDouble(input[1]), Convert.ToDouble(input[2])));
            }
            string input2 = Console.ReadLine();
            while (input2 != "End")
            {
                string[] input = Console.ReadLine().Split(' ');


                input2 = Console.ReadLine();
            }
            
            Console.ReadKey();
        }
    }
}
