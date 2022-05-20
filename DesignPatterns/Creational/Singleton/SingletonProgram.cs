namespace DesignPatterns.Creational.Singleton
{
    public static class SingletonProgram
    {
        // DEF: 
        // Ensures a class has only one instance, and provides a global point of access to it.
        public static void Run()
        {
            var instance = RandomCache.Instance;

            // Adding
            instance.AddItem("Kaio Pedromonico", "kpedromonico@gmail.com");
            instance.AddItem("Kaio Pedromonico", "kpedromonico@gmail.com");

            // Getting
            var instance2 = RandomCache.Instance;
            var item = instance2.GetItem("Kaio Pedromonico");
            Console.WriteLine($"Item: {item.k} / value: {item.v}");

            // Removing
            var instance3 = RandomCache.Instance;
            instance3.RemoveItem("Kaio Pedromonico");
            instance3.RemoveItem("Kaio Pedromonico");
        }
    }
}
