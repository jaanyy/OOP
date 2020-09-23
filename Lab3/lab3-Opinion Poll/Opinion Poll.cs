using System;
using System.Collections.Generic;

namespace lab3_Opinion_Poll
{
    class Opinion_Poll
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person()
            {
                Name = "No name";
                Age = 1;
            }
            public Person(int age)
            {
                Name = "No name";
                Age = age;
            }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List < Person > people = new List< Person >();
            for (int i = 0; i < n; ++i)
            {
                Person person = new Person();
                string[] input = Console.ReadLine().Split(' ');
                person.Name = input[0];
                person.Age =Convert.ToInt32(input[1]);
                people.Add(person);
            }
            List<Person> result = new List<Person>();
            for (int i = 0; i < n; ++i)
            {
                if (people[i].Age > 30)
                {
                    result.Add(people[i]);
                   
                }
            }
            foreach(var a in result)
            {
                Console.WriteLine($"{a.Name} - {a.Age}");
            }
            Console.ReadKey();
        }
    }
}
