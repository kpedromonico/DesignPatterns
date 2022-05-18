using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Pizza
    {
        public string Name { get; set; } = default!;

        public abstract decimal Cost();
    }
}
