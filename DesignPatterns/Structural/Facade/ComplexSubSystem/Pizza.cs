namespace DesignPatterns.Structural.Facade.ComplexSubSystem
{
    public static class Pizza
    {
        public static void MakeDough()
        {
            Console.WriteLine($"The {nameof(Pizza)}'s dough is ready.");
        }

        public static void OpenDough()
        {
            Console.WriteLine($"The {nameof(Pizza)}'s dough is open.");
        }

        public static void AddBaseIngredient(PizzaBase pizzaBase)
        {
            Console.WriteLine($"The {nameof(Pizza)}'s base is {pizzaBase}.");
        }

        public static void AddToppings(IEnumerable<PizzaToppings> pizzaToppings)
        {
            if(!pizzaToppings.Any())
            {
                Console.WriteLine($"The {nameof(Pizza)} has no toppings");
                return;
            }

            Console.WriteLine($"The {nameof(Pizza)}'s toppins are the following:");
            foreach (var x in pizzaToppings)
            {
                Console.WriteLine($"- {x}");
            }
        }
    }

    public enum PizzaBase
    {
        TomatoSauce,
        WhiteSauce,
        BBQ
    }

    public enum PizzaToppings
    {
        Pepperoni,
        Chicken,
        Corn,
        Cheese,
        Pineapple
    }
}
