using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override void Drive(double km)
        {
            FuelConsumption += 0.9;
            if (FuelQuantity >= FuelConsumption * km)
            {
                FuelQuantity -= FuelConsumption * km;
                Console.WriteLine($"Car travelled {km} km");
                return;
            }
            Console.WriteLine("Car needs refueling");
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}
