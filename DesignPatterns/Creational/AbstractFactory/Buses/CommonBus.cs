using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory.Buses
{
    internal class CommonBus : Bus
    {
        public CommonBus(IBusFactory busFactory)
        {
            _busFactory = busFactory;
        }

        protected override void Assemble()
        {
            engine = _busFactory.GetEngine();
            tires = _busFactory.GetTire();
            capacity = _busFactory.GetCapacity();
            maxSpeed = _busFactory.GetMaxSpeed();
        }

        protected override string GenerateDescription()
        {
            return @$"
                Bus produced by: {_busFactory.GetType()} 
                Specs: 
                - Engine: {engine}
                - Number of Tires: {tires}
                - Capable of carrying: {capacity}";
        }
    }
}
