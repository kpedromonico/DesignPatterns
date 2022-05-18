namespace DesignPatterns.Structural.Decorator.Toppings
{
    public class Pepperoni : ToppingsDecorator
    {
        public Pepperoni(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override decimal Cost()
        {
            Console.WriteLine("--> Topping: pepperoni - 5$");
            return Pizza.Cost() + 5M;
        }
    }
}
