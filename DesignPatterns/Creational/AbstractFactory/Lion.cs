using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Lion : Carnivore
    {
        public override bool Eat(Herbivore herbivore)
        {
            return true;
        }
    }
}
