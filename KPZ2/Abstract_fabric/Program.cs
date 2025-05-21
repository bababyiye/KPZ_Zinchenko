using System;
using Abstract_fabric.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IDeviceFactory[] factories = {
            new IProneFactory(),
            new KiaomiFactory(),
            new BalaxyFactory()
        };

        foreach (var factory in factories)
        {
            string brand = factory.GetType().Name.Replace("Factory", "");
            Console.WriteLine($"=== Devices from {brand} ===");

            factory.CreateLaptop().ShowInfo();
            factory.CreateNetbook().ShowInfo();
            factory.CreateEBook().ShowInfo();
            factory.CreateSmartphone().ShowInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
