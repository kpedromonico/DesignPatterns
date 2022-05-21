using DesignPatterns.Structural.Adapter.NonStandardOutlet;
using DesignPatterns.Structural.Adapter.Outlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public static class AdapterProgram
    {
        // DEF: Converts the interface of a class into another interface the clients expects.
        // Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
        public static void Run()
        {
            IOutlet outlet;

            Console.WriteLine("--------------------------");
            outlet = new BROutlet();
            outlet.ConnectToOutlet();

            Console.WriteLine("--------------------------");
            outlet = new USOutlet();
            outlet.ConnectToOutlet();


            // Connecting a non-standard input
            Console.WriteLine("--------------------------");
            var usb = new USBInput();
            outlet = new USBAdapter(new USOutlet(), usb);
            outlet.ConnectToOutlet();
        }
    }
}
