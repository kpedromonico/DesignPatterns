using DesignPatterns.Creational.AbstractFactory.Buses;
using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory
{
    public static class AbstractFactoryProgram
    {
        public static void Run()
        {
            Console.WriteLine($"Welcome to the bus shop, we do have two types of each bus");
            Console.WriteLine("Find bellow their descriptions");
            Console.WriteLine($"---------------------------");

            IBusFactory badCorporation = new BigBadBusCorporationFactory();
            IBusFactory hipsterCorporation = new SmallBusCorporationFactory();

            Console.WriteLine($"Here the first factory....");
            Console.WriteLine(GenerateBusesDescriptionPerFactory(badCorporation));

            Console.WriteLine($"---------------------------");

            Console.WriteLine($"Now the second factory....");
            Console.WriteLine(GenerateBusesDescriptionPerFactory(hipsterCorporation));
        }

        private static string GenerateBusesDescriptionPerFactory(IBusFactory factory)
        {
            Bus commonBus = new CommonBus(factory);
            Bus articulatedBus = new ArticulatedBus(factory);

            return @$"
                    {commonBus.GetDescription()}
                    --------------------------- 
                    {articulatedBus.GetDescription()}";
        }
    }
}
