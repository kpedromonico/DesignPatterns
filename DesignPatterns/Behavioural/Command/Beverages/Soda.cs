using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command.Beverages
{
    internal class Soda
    {
        public void ServeSoda(SodaType sodaType, SodaSize sodaSize)
        {
            Console.WriteLine($"Filling a {sodaSize} cup of {sodaType}");
        }
    }

    internal enum SodaType
    {
        COKE,
        SPRITE,
        PEPSI
    }

    internal enum SodaSize
    {
        S,
        M,
        L,
        XL
    }
}
