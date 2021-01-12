using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle;  }
        }

        public abstract void AssembleDoors();

        public abstract void AssembleTank();

        public abstract void AssembleEngine();

        public abstract void AssembleSeats();
    }
}
