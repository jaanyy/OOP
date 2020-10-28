using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Google
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                string property = input[1];
                int temp = 0;
                foreach (var p in people)
                {
                    if ((p.Name == name))
                    {
                        temp++;
                    }
                }
                if (temp == 0)
                {
                    people.Add(new Person(name));
                }
                                
                var current = people.First(p => p.Name == name);

                switch (property)
                {
                    case "company":
                        current.AssignCompany(input[2], input[3], Convert.ToDecimal(input[4].Replace('.', ',')));
                        break;
                    case "pokemon":
                        current.AddPokemon(input[2], input[3]);
                        break;
                    case "parents":
                        string parentName = input[2];
                        current.AddParent(new Person(parentName, input[3]));
                        break;
                    case "children":
                        string childName = input[2];
                        current.AddChild(new Person(childName, input[3]));
                        break;
                    case "car":
                        current.AssignCar(input[2], int.Parse(input[3]));
                        break;
                    default:
                        throw new Exception();
                }
            }

            command = Console.ReadLine();

            Person result = people.First(p => p.Name == command);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
