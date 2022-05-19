using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory.Buses
{
    internal class ArticulatedBus : Bus
    {
        public ArticulatedBus(IBusFactory busFactory)
        {
            _busFactory = busFactory;
        }

        protected override void Assemble()
        {
            engine = _busFactory.GetEngine() + " modified to carry a lot of people";
            tires = _busFactory.GetTire() + " * 2";
            capacity = _busFactory.GetCapacity() * 3;
            maxSpeed = _busFactory.GetMaxSpeed() + " * 1.5";
        }

        protected override string GenerateDescription()
        {
            return @$"
                Articulated Bus produced by: {_busFactory.GetType()} 
                Specs: 
                - Engine: {engine}
                - Number of Tires: {tires}
                - Capable of carrying: {capacity}";       
        }
    }
}
