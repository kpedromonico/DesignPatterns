using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    public class AbstractFactoryUnitTests
    {
        // To exemplify abstract factory, I'm following the UML proposed by the GoF's website
        // Where they create some sort of food chain based on which continent the animal is located at.


        [Fact]
        public void Lion_ExistsOnAfricaContinent_AndEatAZebra()
        {
            // Arrange
            var lion = new Lion();
            var zebra = new Zebra();

            // Act
            var result = lion.Eat(zebra);

            // Assert
            Assert.True(result);
        }


        [Fact]
        public void AfricaContinent_ReturnsAZebra_AsHerbivore()
        {
            // Arrange
            ContinentFactory factory = new AfricaFactory();

            // Act
            var herbivore = factory.CreateHerbivore();

            // Assert 
            Assert.IsAssignableFrom<Zebra>(herbivore);
        }

        [Fact]
        public void AnimalWorldReceivesAfrica_AndLionEatsZebra()
        {
            var animalWorld = new AnimalWorld(new AfricaFactory());

            var result = animalWorld.FoodChain();

            Assert.True(result);
            Assert.IsType<Lion>(animalWorld.carnivore);
            Assert.IsType <Zebra>(animalWorld.herbivore);
        }


        [Fact]
        public void AnimalWorldReceivesSouthAmerica_AndItsCarnivoreIsNotALion()
        {
            var animalWorld = new AnimalWorld(new SouthAmericaFactory());

            var result = animalWorld.FoodChain();

            Assert.True(result);
            Assert.IsNotType<Lion>(animalWorld.carnivore);            
        }

        [Fact]
        public void AnimalWorldReceivesSouthAmerica_AndGuepardoEatsMonkey()
        {
            var animalWorld = new AnimalWorld(new SouthAmericaFactory());

            var result = animalWorld.FoodChain();

            Assert.True(result);
            Assert.IsType<Guepardo>(animalWorld.carnivore);
            Assert.IsType<Monkey>(animalWorld.herbivore);
        }
    }
}
