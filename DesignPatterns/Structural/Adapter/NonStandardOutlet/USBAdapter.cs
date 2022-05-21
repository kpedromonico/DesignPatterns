using DesignPatterns.Structural.Adapter.Outlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.NonStandardOutlet
{
    internal class USBAdapter : IOutlet
    {
        private readonly IOutlet _outlet;
        private readonly USBInput _input;

        public USBAdapter(IOutlet outlet, USBInput input)
        {
            _outlet = outlet;
            _input = input;
        }

        public void ConnectToOutlet()
        {
            Console.WriteLine($"Adapting USB to ... {_outlet.GetType()}");
            _input.ConnectToPower();
            _outlet.ConnectToOutlet();
        }
    }
}
