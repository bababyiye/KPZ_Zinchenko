using System;
using Abstract_fabric.Interfaces;

public class BalaxyFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new BalaxyLaptop();
    public INetbook CreateNetbook() => new BalaxyNetbook();
    public IEBook CreateEBook() => new BalaxyEBook();
    public ISmartphone CreateSmartphone() => new BalaxySmartphone();
}

public class BalaxyLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("Balaxy Laptop");
}

public class BalaxyNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("Balaxy Netbook");
}

public class BalaxyEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("Balaxy E-Book");
}

public class BalaxySmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("Balaxy Smartphone");
}
