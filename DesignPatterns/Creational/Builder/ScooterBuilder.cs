using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        public override void AssembleDoors()
        {
            vehicle.Doors = 0;
        }

        public override void AssembleEngine()
        {
            vehicle.HorsePower = 125;
        }

        public override void AssembleSeats()
        {
            vehicle.SeatAmount = 1;
        }

        public override void AssembleTank()
        {
            vehicle.TankCapacity = 5;
        }
    }
}
