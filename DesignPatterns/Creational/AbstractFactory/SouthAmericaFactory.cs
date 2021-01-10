using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SouthAmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Guepardo();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Monkey();
        }
    }
}
