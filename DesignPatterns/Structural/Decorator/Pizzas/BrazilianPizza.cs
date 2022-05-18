namespace DesignPatterns.Structural.Decorator
{
    public class BrazilianPizza : Pizza
    {
        public BrazilianPizza()
        {
            Name = "Brazilian Pizza";
        }

        public override decimal Cost()
        {
            Console.WriteLine("--> Dough: brazil - 20$");
            return 20M;
        }
    }
}
