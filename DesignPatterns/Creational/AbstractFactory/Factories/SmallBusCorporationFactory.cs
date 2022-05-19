namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class SmallBusCorporationFactory : IBusFactory
    {
        public int GetCapacity()
        {
            return 150;
        }

        public string GetEngine()
        {
            return "Engine 150hp";
        }

        public string GetMaxSpeed()
        {
            return "MaxSpeed 140mph";
        }

        public string GetTire()
        {
            return "Tires 16";
        }
    }
}
