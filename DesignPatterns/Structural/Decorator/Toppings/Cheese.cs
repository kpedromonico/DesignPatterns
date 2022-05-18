namespace DesignPatterns.Structural.Decorator.Toppings
{
    public class Cheese : ToppingsDecorator
    {
        public Cheese(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override decimal Cost()
        {
            Console.WriteLine("--> Topping: thick layer of cheese - 2$");
            return Pizza.Cost() + 2M;
        }
    }
}
