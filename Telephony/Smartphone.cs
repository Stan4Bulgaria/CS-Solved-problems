using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public void Browsing(string url)
        {
            if (url.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }
            Console.WriteLine($"Browsing: {url}!");
          
            

        }

        public void Calling(string number)
        {
            if (number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
                return;
                
            }
            Console.WriteLine("Invalid number!");
            

        }
    }
}
