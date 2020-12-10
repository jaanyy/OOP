using System;
using System.Collections.Generic;
using System.Linq;

namespace L15_12_OfficeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    Dictionary<string, Company> companies = new Dictionary<string, Company>();
                    char[] chars = { ' ', '-', '|' };
                    for (int i = 0; i < n; i++)
                    {
                        string[] input = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries);
                        if (companies.ContainsKey(input[0]))
                        {
                            try
                            {
                                companies[input[0]].AddProduct(input[2], Convert.ToInt32(input[1]));
                            }
                            catch (Exception x)
                            {
                                Console.WriteLine(x.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                Company t = new Company(input[0]);
                                t.AddProduct(input[2], Convert.ToInt32(input[1]));
                                companies.Add(input[0], t);
                            }
                            catch (Exception x)
                            {
                                Console.WriteLine(x.Message);
                            }
                        }
                    }
                    foreach (var company in companies.OrderBy(x => x.Key))
                        Console.WriteLine(company.Value);
                }
                else
                    throw new Exception("Invalid number of commands!");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
