namespace DesignPatterns.Behavioural.Command
{
    internal class Order
    {
        ICommand _command;

        public Order(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void StartOrder()
        {
            _command.Execute();
        }
    }
}
