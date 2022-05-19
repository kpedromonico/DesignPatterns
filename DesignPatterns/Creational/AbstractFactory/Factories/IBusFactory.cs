namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal interface IBusFactory
    {
        public string GetEngine();

        public string GetTire();

        public string GetMaxSpeed();

        public int GetCapacity();
    }
}
