using System;
using System.Collections.Generic;

namespace Lab3
{
    class Lab3p2
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
        class Family
        {
            private List<Person> members;
            public Family()
            {
                members = new List<Person>();
            }
            public void AddMember (Person member)
            {
                members.Add(member);
            }
            public Person GetOldestMember()
            {
                int tempMaxAge = members[0].Age;
                Person result = members[0];
                foreach (var a in members)
                {
                    if (a.Age > tempMaxAge)
                    {
                        tempMaxAge = a.Age;
                        result = a;
                    }
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Family f1 = new Family();
            for (int i = 0; i < N; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                Person person = new Person();
                person.Name = input[0];
                person.Age = Convert.ToInt32(input[1]);
                f1.AddMember(person);
            }
            Person old = f1.GetOldestMember();
            Console.WriteLine($"{old.Name} {old.Age}");
        }
    }
}
