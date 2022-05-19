using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Vehicles
{
    internal class Bus : Vehicle
    {
        public override int MaxSpeed() => 150;
    }
}
