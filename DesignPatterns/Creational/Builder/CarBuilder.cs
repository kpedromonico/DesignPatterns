using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder() 
        {
            vehicle = new Vehicle("Car");
        }

        public override void AssembleDoors()
        {
            vehicle.Doors = 5;
        }

        public override void AssembleEngine()
        {
            vehicle.HorsePower = 650;
        }

        public override void AssembleSeats()
        {
            vehicle.SeatAmount = 4;
        }

        public override void AssembleTank()
        {
            vehicle.TankCapacity = 20;
        }
    }
}
