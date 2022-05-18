namespace DesignPatterns.Structural.Decorator
{
    public class NewYorkPizza : Pizza
    {
        public NewYorkPizza()
        {
            Name = "New York Pizza";
        }

        public override decimal Cost()
        {
            Console.WriteLine("--> Dough: newyork - 11$");
            return 11M;
        }
    }
}
