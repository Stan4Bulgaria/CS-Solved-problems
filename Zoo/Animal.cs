using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        private string name;
        public Animal(string name)
        {
            Name = name;
            this.name = name;
        }
    }
}
