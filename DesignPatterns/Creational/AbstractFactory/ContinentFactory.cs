using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();
    }
}
