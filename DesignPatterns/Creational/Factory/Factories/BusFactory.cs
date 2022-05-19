using DesignPatterns.Creational.Factory.Vehicles;

namespace DesignPatterns.Creational.Factory.Factories
{
    internal class BusFactory : VehicleFactory
    {
        public override Vehicle GetVehicle()
        {
            return new Bus();
        }
    }
}
