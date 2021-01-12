using System;
using System.Collections.Generic;
using System.Text;

using DesignPatterns.Creational.Builder;
using Xunit;

namespace DesignPatterns.Tests.Creational.Builder
{
    public class BuilderUnitTests
    {
        private Shop _shop;

        public BuilderUnitTests()
        {
            _shop = new Shop();
        }

        [Fact]
        public void AssemblingACar_GeneratesAVehicleWith4OrMoreDoors()
        {
            // Arrange
            var carBuilder = new CarBuilder();

            // Act
            _shop.AssembleVehicle(carBuilder);

            // Assert
            Assert.True(carBuilder.Vehicle.Doors > 4);
        }

        [Fact]
        public void AssemblingAScooter_GeneratesAVehicleWithLessThan200CC()
        {
            // Arrange
            var scooterBuilder = new ScooterBuilder();

            // Act
            _shop.AssembleVehicle(scooterBuilder);

            // Assert
            Assert.True(scooterBuilder.Vehicle.HorsePower < 200);
        }


        [Fact]
        public void ShopCanAssemble_MoreThanOneVehicle_WithoutAnyError()
        {
            // Arrange
            var scooterBuilder = new ScooterBuilder();
            var carBuilder = new CarBuilder();

            // Act
            _shop.AssembleVehicle(scooterBuilder);
            _shop.AssembleVehicle(carBuilder);

            // Assert
            Assert.NotNull(carBuilder.Vehicle);
            Assert.NotNull(scooterBuilder.Vehicle);
        }
    }
}
