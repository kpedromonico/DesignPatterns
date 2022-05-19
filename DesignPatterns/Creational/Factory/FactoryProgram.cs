using DesignPatterns.Creational.Factory.Factories;
using DesignPatterns.Creational.Factory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public static class FactoryProgram
    {
        public static void Run()
        {
            VehicleFactory vehicleFactory;
            Vehicle vehicle;

            Console.WriteLine($"-----------");

            vehicleFactory = new CarFactory();
            vehicle = vehicleFactory.PurchaseVehicle();
            Console.WriteLine($"It's Max Speed is: {vehicle.MaxSpeed()}");

            Console.WriteLine($"-----------");

            vehicleFactory = new BusFactory();
            vehicle = vehicleFactory.PurchaseVehicle();
            Console.WriteLine($"It's Max Speed is: {vehicle.MaxSpeed()}");

        }
    }
}
