namespace DesignPatterns.Structural.Facade
{
    // DEF: You can get a complex subsystem and create a simplified interface to its functionality.
    // It also decouples your system from any underlying subsystem.
    public static class FacadeProgram
    {
        public static void Run()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Let's bake first a chicken pizza");
            BakingPizzaFacade.BakeChickenPizza();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Now let's bake a pepperoni pizza");
            BakingPizzaFacade.BakePepperoniPizza();
        }
    }
}
