using DesignPatterns.Behavioural.Command.Meals;

namespace DesignPatterns.Behavioural.Command.Commands
{
    internal class PreparePizzaCommand : ICommand
    {
        private readonly Pizza _pizza;

        public PreparePizzaCommand(Pizza burger)
        {
            _pizza = burger;
        }

        public void Execute()
        {
            Console.WriteLine($"Command: {nameof(PreparePizzaCommand)}");
            _pizza.Prepare();
        }
    }
}
