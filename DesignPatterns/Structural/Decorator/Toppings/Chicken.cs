namespace DesignPatterns.Structural.Decorator.Toppings
{
    public class Chicken : ToppingsDecorator
    {
        public Chicken(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override decimal Cost()
        {
            Console.WriteLine("--> Topping: chicken - 10$");
            return Pizza.Cost() + 10M;
        }
    }
}
