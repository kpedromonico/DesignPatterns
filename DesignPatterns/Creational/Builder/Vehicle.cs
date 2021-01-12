using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Vehicle
    {
        public Vehicle(string VehicleType)
        {
            _type = VehicleType;
        }

        protected string _type;

        public string Type
        {
            get { return _type; }
        }

        public int Doors { get; set; }        

        public int HorsePower { get; set; }

        public int SeatAmount { get; set; }

        public int TankCapacity { get; set; }        
    }
}
