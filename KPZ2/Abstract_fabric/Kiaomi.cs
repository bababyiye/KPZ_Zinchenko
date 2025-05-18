using System;
using Abstract_fabric.Interfaces;

public class KiaomiFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new KiaomiLaptop();
    public INetbook CreateNetbook() => new KiaomiNetbook();
    public IEBook CreateEBook() => new KiaomiEBook();
    public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
}

public class KiaomiLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Laptop");
}

public class KiaomiNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Netbook");
}

public class KiaomiEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("Kiaomi E-Book");
}

public class KiaomiSmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Smartphone");
}
