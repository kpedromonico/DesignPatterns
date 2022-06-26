using DesignPatterns.Structural.Adapter.NonStandardOutlet;
using DesignPatterns.Structural.Adapter.Outlet;

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
            ConnectToOutlet(outlet);

            Console.WriteLine("--------------------------");
            outlet = new USOutlet();
            ConnectToOutlet(outlet);


            // Connecting a non-standard input
            Console.WriteLine("--------------------------");
            var usb = new USBInput();
            outlet = new USBAdapter(new USOutlet(), usb);
            ConnectToOutlet(outlet);
        }

        internal static void ConnectToOutlet(IOutlet outlet)
        {
            outlet.ConnectToOutlet();
        }
    }
}
