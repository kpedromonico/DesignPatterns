using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory.Buses
{
    internal abstract class Bus
    {
        protected IBusFactory _busFactory;
        protected string engine;
        protected string tires;
        protected string maxSpeed;
        protected int capacity;

        protected abstract void Assemble();

        protected abstract string GenerateDescription();

        public string GetDescription()
        {
            Assemble();

            return GenerateDescription();
        }
    }
}
