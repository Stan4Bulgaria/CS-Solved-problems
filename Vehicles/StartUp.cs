using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] carInput = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(carInput[1]); 
            double consumedFuel = double.Parse(carInput[2]);
            Vehicle vehicle = new Car(fuelQuantity,consumedFuel);
            vehicles.Add(vehicle);

            string[] truckInput = Console.ReadLine().Split();
            double fuelQuantityTruck = double.Parse(truckInput[1]);
            double consumedFuelTruck = double.Parse(truckInput[2]);
            vehicle = new Truck(fuelQuantityTruck, consumedFuelTruck);
            vehicles.Add(vehicle);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        vehicles[0].Drive(double.Parse(command[2]));
                    }
                    else
                    {
                        vehicles[1].Drive(double.Parse(command[2]));
                    }
                }
                else
                {
                    if (command[1] == "Car")
                    {
                        vehicles[0].Refuel(double.Parse(command[2]));
                    }
                    else
                    {
                        vehicles[1].Refuel(double.Parse(command[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {vehicles[0].FuelQuantity:f2}");
            Console.WriteLine($"Truck: {vehicles[1].FuelQuantity:f2}");
        }
    }
}
