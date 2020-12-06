using System;

namespace L9_7.CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();

                switch (input[0])
                {
                    case "Add":
                        {
                            list.Add(input[1]);
                            break;
                        }
                    case "Remove":
                        {
                            list.Remove(Convert.ToInt32(input[1]));
                            break;
                        }
                    case "Contains":
                        {
                            Console.WriteLine(list.Contains(input[1]));
                            break;
                        }
                    case "Swap":
                        {
                            list.Swap(Convert.ToInt32(input[1]), Convert.ToInt32(input[2]));
                            break;
                        }
                    case "Greater":
                        {
                            Console.WriteLine(list.CountGreaterThan(input[1]));
                            break;
                        }
                    case "Max":
                        {
                            Console.WriteLine(list.Max());
                            break;
                        }
                    case "Min":
                        {
                            Console.WriteLine(list.Min());
                            break;
                        }
                    default:
                        throw new ArgumentException();
                }
            }

            Console.ReadKey();
        }
    }
}
