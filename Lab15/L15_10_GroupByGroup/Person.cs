using System;
using System.Collections.Generic;
using System.Text;

namespace L15_10_GroupByGroup
{
    class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public Person(string name, int group)
        {
            Name = name;
            Group = group;
        }
    }
}
