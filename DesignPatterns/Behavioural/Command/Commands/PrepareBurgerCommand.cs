using DesignPatterns.Behavioural.Command.Meals;

namespace DesignPatterns.Behavioural.Command.Commands
{
    internal class PrepareBurgerCommand : ICommand
    {
        private readonly Burger _burger;

        public PrepareBurgerCommand(Burger burger)
        {
            _burger = burger;
        }

        public void Execute()
        {
            Console.WriteLine($"Command: {nameof(PrepareBurgerCommand)}");
            _burger.Prepare();
        }
    }
}
