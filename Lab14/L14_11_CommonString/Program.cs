using System;

namespace L14_11_CommonString
{
    class Program
    {
        static void Main(string[] args)
        {
            string row1 = Console.ReadLine();
            string row2 = Console.ReadLine();
            bool isCommon = false;
            for (int i = 1; i <= row1.Length; i++)
            {
                for (int j = 0; j < row1.Length - i + 1; j++)
                    if (row2.Contains(row1.Substring(j, i)))
                    {
                        isCommon = true;
                        break;
                    }
            }
            if (isCommon)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
