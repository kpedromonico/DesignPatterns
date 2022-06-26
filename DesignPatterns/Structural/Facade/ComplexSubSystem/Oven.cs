namespace DesignPatterns.Structural.Facade.ComplexSubSystem
{
    public static class Oven
    {
        public static void On() 
        {
            Console.WriteLine($"{nameof(Oven)} is on.");
        }

        public static void Off()
        {
            Console.WriteLine($"{nameof(Oven)} is off.");
        }

        public static void PreHeat(double temp)
        {
            Console.WriteLine($"{nameof(Oven)} is about to preheat to {temp}.");
        }

        public static void SetTemperature(double temp)
        {
            Console.WriteLine($"{nameof(Oven)}'s temperature is set to {temp}.");
        }

        public static void SetMode(OvenModes mode)
        {
            Console.WriteLine($"{nameof(Oven)}'s mode is set to {mode}.");
        }

        public static void Cook(string cookedItem, int minutes)
        {
            Console.WriteLine($"{nameof(Oven)} cooked {cookedItem} for {minutes} minutes.");
        }
    }

    public enum OvenModes
    {
        Off,
        Fan,
        Grill,
        Bake,
        Pizza
    }
}
