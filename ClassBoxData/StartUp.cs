using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double input = 0;
            double lenght = 0;
            double width = 0;
            double height = 0;
            for (int i = 0; i < 3; i++)
            {
                input = double.Parse(Console.ReadLine());
                if(i == 0)
                {
                    lenght = input;
                }
                else if(i == 1)
                {
                    width = input;
                }
                else if(i == 2)
                {
                    height = input;
                }

            }
            Box box = new Box();
            try
            {
                box = new Box(lenght, width, height);
            }
            catch(ArgumentException argument)
            {
                Console.WriteLine(argument.Message);
                return;
            }
            Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.Volume():f2}");
        }
    }
}
