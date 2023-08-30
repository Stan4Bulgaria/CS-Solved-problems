using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("xxxYourMomsLoverxxx", 120);
            Console.WriteLine(wizard.ToString());
        }
    }
}
