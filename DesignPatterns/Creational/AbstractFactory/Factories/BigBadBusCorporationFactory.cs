namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class BigBadBusCorporationFactory : IBusFactory
    {
        public int GetCapacity()
        {
            return 100;
        }

        public string GetEngine()
        {
            return "Engine 100hp";
        }

        public string GetMaxSpeed()
        {
            return "MaxSpeed 120mph";
        }

        public string GetTire()
        {
            return "Tires 8";
        }
    }
}
