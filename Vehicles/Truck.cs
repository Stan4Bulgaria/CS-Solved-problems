using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        public override void Drive(double km)
        {

            FuelConsumption += 1.6;
            if (FuelQuantity >= FuelConsumption * km)
            {
                FuelQuantity -= FuelConsumption * km;
                Console.WriteLine($"Truck travelled {km} km");
                return;
            }
            Console.WriteLine("Truck needs refueling");
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel * 0.95;
        }
    }
}
