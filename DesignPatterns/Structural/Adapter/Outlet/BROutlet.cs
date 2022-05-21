using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Outlet
{
    internal class BROutlet : IOutlet
    {
        public void ConnectToOutlet()
        {
            Console.WriteLine("BR Outlet connected: 2 pins / 110 V");
        }
    }
}
