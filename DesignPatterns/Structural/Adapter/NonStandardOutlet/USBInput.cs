using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.NonStandardOutlet
{
    internal class USBInput
    {
        public void ConnectToPower()
        {
            Console.WriteLine($"USB is connect to energy");
        }
    }
}
