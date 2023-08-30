using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet :IBirthDay
    {
        public Pet(string name, string birthDay)
        {
            Name = name;
          
            BirthDay = birthDay;
        }

        public string Name { get; set; }  
     
        public string BirthDay { get; set; }
    }
}
