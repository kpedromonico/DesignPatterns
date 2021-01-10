using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class Carnivore
    {
        public Carnivore()
        {

        }

        public abstract bool Eat(Herbivore herbivore);
    }
}
