using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral:Private
    {
        public LieutenantGeneral(string id,string firstName ,string lastName, decimal salary):base(id,firstName,lastName,salary)
        {
            Privates = new Dictionary<string, Private>();
        }
        public Dictionary<string,Private> Privates { get; set; }
    }
}
