using DesignPatterns.Creational.Factory.Vehicles;

namespace DesignPatterns.Creational.Factory.Factories
{
    internal abstract class VehicleFactory
    {
        public abstract Vehicle GetVehicle();

        public Vehicle PurchaseVehicle()
        {
            var vehicle = GetVehicle();
            Console.WriteLine($"You've purchased a {vehicle.GetType()}");
            return vehicle;
        }
    }
}
