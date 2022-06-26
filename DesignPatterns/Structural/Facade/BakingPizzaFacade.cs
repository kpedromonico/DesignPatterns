using DesignPatterns.Structural.Facade.ComplexSubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public static class BakingPizzaFacade
    {
        public static void BakeChickenPizza()
        {
            Oven.On();
            Oven.PreHeat(220.0);
            Oven.SetTemperature(300);
            Oven.SetMode(OvenModes.Pizza);

            Pizza.MakeDough();
            Pizza.OpenDough();
            Pizza.AddBaseIngredient(PizzaBase.BBQ);
            Pizza.AddToppings(new List<PizzaToppings>
            {
                PizzaToppings.Cheese,
                PizzaToppings.Chicken,
                PizzaToppings.Corn
            });

            Oven.Cook("Chicken pizza", 10);
        }

        public static void BakePepperoniPizza()
        {
            Oven.On();
            Oven.PreHeat(180);
            Oven.SetTemperature(250);
            Oven.SetMode(OvenModes.Pizza);

            Pizza.MakeDough();
            Pizza.OpenDough();
            Pizza.AddBaseIngredient(PizzaBase.TomatoSauce);
            Pizza.AddToppings(new List<PizzaToppings>
            {
                PizzaToppings.Cheese,
                PizzaToppings.Pepperoni
            });

            Oven.Cook("Pepperoni pizza", 10);
        }
    }
}
