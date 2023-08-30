using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryphone
    {
        public void Dialing(string numbers)
        {
            if (numbers.All(char.IsDigit))
            {
                Console.WriteLine($"Dialing... {numbers}");
                return;
            }
            Console.WriteLine("Invalid number!");
        }
    }
}
