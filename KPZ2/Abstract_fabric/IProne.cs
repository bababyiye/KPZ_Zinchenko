using System;
using Abstract_fabric.Interfaces;

public class IProneFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new IProneLaptop();
    public INetbook CreateNetbook() => new IProneNetbook();
    public IEBook CreateEBook() => new IProneEBook();
    public ISmartphone CreateSmartphone() => new IProneSmartphone();
}

public class IProneLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("IProne Laptop");
}

public class IProneNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("IProne Netbook");
}

public class IProneEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("IProne E-Book");
}

public class IProneSmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("IProne Smartphone");
}
