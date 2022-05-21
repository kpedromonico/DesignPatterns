using DesignPatterns.Behavioural.Command.Beverages;
using DesignPatterns.Behavioural.Command.Meals;

namespace DesignPatterns.Behavioural.Command.Commands
{
    internal class PrepareBurguerComboCommand : ICommand
    {
        private readonly Burger _burger;
        private readonly Soda _soda;

        public PrepareBurguerComboCommand(Burger burger, Soda soda)
        {
            _burger = burger;
            _soda = soda;
        }

        public void Execute()
        {
            Console.WriteLine($"Command: {nameof(PrepareBurguerComboCommand)}");
            _burger.Prepare();
            _soda.ServeSoda(SodaType.COKE, SodaSize.M);
        }
    }
}
