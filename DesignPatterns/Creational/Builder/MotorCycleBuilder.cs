using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public override void AssembleDoors()
        {
            vehicle.Doors = 0;
        }

        public override void AssembleEngine()
        {
            vehicle.HorsePower = 250;
        }

        public override void AssembleSeats()
        {
            vehicle.SeatAmount = 2;
        }

        public override void AssembleTank()
        {
            vehicle.TankCapacity = 15;
        }
    }
}
