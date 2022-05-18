using DesignPatterns.Structural.Decorator.Toppings;

namespace DesignPatterns.Structural.Decorator
{
    // DEF: Attaches addditional responsabilities to an obj dynamically.
    // They provide a flexible alternative to subclassing for extending functionality.
    public static class DecoratorProgram
    {
        public static void Run()
        {
            Pizza pizza1 = new BrazilianPizza();
            pizza1 = new Chicken(pizza1);
            pizza1 = new Cheese(pizza1);
            pizza1 = new Cheese(pizza1);

            Console.WriteLine($"Finished: {pizza1.Name} / Cost: {pizza1.Cost()}");
            Console.WriteLine("-------------");

            Pizza pizza2 = new NewYorkPizza();
            pizza2 = new Pepperoni(pizza2);
            pizza2 = new Cheese(pizza2);

            Console.WriteLine($"Finished: {pizza2.Name} / Cost: {pizza2.Cost()}");
            Console.WriteLine("-------------");
        }
    }
}
