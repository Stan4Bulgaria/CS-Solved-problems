using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;

        public Person( string name, int age)
        {
            Age = age;
            Name = name;
            this.age = age;
            this.name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format($"Name: {Name}, Age: {Age}"));
            return sb.ToString();

        }
    }
}
