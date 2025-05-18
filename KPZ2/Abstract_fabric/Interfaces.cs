using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_fabric.Interfaces
{
    public interface ILaptop
    {
        void ShowInfo();
    }

    public interface INetbook
    {
        void ShowInfo();
    }

    public interface IEBook
    {
        void ShowInfo();
    }

    public interface ISmartphone
    {
        void ShowInfo();
    }

    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }
}

