using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : ICheckable,IBirthDay,IBuyer
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDay = birthday;    
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDay { get ; set ; }
        public int Food { get ; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
