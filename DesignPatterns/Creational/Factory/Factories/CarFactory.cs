using DesignPatterns.Creational.Factory.Vehicles;

namespace DesignPatterns.Creational.Factory.Factories
{
    internal class CarFactory : VehicleFactory
    {
        public override Vehicle GetVehicle()
        {
            return new Car();
        }
    }
}
