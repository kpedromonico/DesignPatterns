using DesignPatterns.Behavioural.Command.Beverages;
using DesignPatterns.Behavioural.Command.Commands;
using DesignPatterns.Behavioural.Command.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    // DEF:
    // Encapsulates a request as an object , thereby letting you parameterize other objects
    // with different requests, queue or log requests, and support undoable operations.
    public static class CommandProgram
    {
        public static void Run()
        {
            var burger = new Burger();
            var soda = new Soda();

            ICommand command1 = new PrepareBurgerCommand(burger);
            var order = new Order(command1);
            order.StartOrder();

            command1 = new PrepareBurguerComboCommand(burger, soda);
            order.SetCommand(command1);
            order.StartOrder();

        }
    }
}
