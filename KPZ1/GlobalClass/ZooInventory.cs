using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalClass
{

    public class ZooInventory
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();


        public void DisplayInventory()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("--- Інвентаризація зоопарку ---\n");
            Console.WriteLine("Тварини:");
            foreach (var animal in Animals)
            {
                animal.DisplayInfo();
            }
            Console.WriteLine("\n");


            Console.WriteLine("Працівники:");
            foreach (var employee in Employees)
            {
                employee.DisplayEmployeeInfo();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Вольєри:");
            foreach(var enclosure in Enclosures)
            {
                enclosure.DisplayEnclosureInfo();
            }
        }
    }
}
