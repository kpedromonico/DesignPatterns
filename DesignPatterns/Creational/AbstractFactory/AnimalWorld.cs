using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AnimalWorld
    {
        public Herbivore herbivore;
        public Carnivore carnivore;

        public AnimalWorld(ContinentFactory continent)
        {
            herbivore = continent.CreateHerbivore();
            carnivore = continent.CreateCarnivore();
        }

        public bool FoodChain()
        {
            return carnivore.Eat(herbivore);
        }
    }
}
