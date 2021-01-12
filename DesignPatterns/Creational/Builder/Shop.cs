using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Shop
    {
        public void AssembleVehicle(VehicleBuilder builder)
        {
            builder.AssembleDoors();
            builder.AssembleEngine();
            builder.AssembleSeats();
            builder.AssembleTank();
        }
    }
}
