using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ISmartphone smartphone = new Smartphone();
            IStationaryphone stationaryphone = new StationaryPhone();
            string[] numbers = Console.ReadLine().Split();
            string[] ulrs = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Length == 7)
                {
                    stationaryphone.Dialing(numbers[i]);
                }
                if(numbers[i].Length == 10)
                {
                    smartphone.Calling(numbers[i]);
                }
            }
            for (int i = 0; i < ulrs.Length; i++)
            {
                smartphone.Browsing(ulrs[i]);
            }

        }
    }
}
