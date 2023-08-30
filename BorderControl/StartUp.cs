using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> people = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4) 
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthDay = input[3];
                    people[input[0]] = new Citizen(name,age,id,birthDay);
                }
                else if(input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    people[name] = new Rebel(name, age, group);
                }
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                if (people.ContainsKey(command))
                {
                    people[command].BuyFood();
                }
                command = Console.ReadLine();
            }
            int food = 0;
            foreach (var person in people)
            {
                food += person.Value.Food;
            }
            Console.WriteLine(food);
           
        }
    }
}
