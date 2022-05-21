using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Outlet
{
    internal class USOutlet : IOutlet
    {
        public void ConnectToOutlet()
        {
            Console.WriteLine("US Outlet connected: 3 pins / 220 V");
        }
    }
}
