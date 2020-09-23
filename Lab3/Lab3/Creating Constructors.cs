using System;

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
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"{p1.Name} - {p1.Age}");
        }
    }
}
