using System;

namespace lab3_Date_Modifier
{
    class DateModifier
    {
        public int Difference { get; set; }
        public void CalculateDifference (string first, string second)
        {
            DateTime f = Convert.ToDateTime(first);
            DateTime s = Convert.ToDateTime(second);
            Difference = Math.Abs((f - s).Days);
        }
    }
    class Date_Modifier
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            string t2 = Console.ReadLine();
            DateModifier r = new DateModifier();
            r.CalculateDifference(t1, t2);
            Console.WriteLine(r.Difference);

            Console.ReadKey();

        }
    }
}
