using System;

namespace L9_10.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Tuple<string, string> tuple1 = new Tuple<string, string>(input[0] + " " + input[1], input[2]);
            Console.WriteLine(tuple1);

            input = Console.ReadLine().Split();
            Tuple<string, int> tuple2 = new Tuple<string, int>(input[0], Convert.ToInt32(input[1]));
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split();
            Tuple<int, double> tuple3 = new Tuple<int, double>(Convert.ToInt32(input[0]), Convert.ToDouble(input[1].Replace('.',',')));
            Console.WriteLine(tuple3);

            Console.ReadKey();
        }
    }
}
