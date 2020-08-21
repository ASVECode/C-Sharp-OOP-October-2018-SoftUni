using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Oldest_Family_Member
{
    public class Person
    {
        private string name;
        private int age;

        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
}
