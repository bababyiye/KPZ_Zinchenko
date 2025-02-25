using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalClass
{

    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Diet { get; set; }

        public Animal(string name, string species, string diet)
        {
            Name = name;
            Species = species;
            Diet = diet;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Тварина: {Name}, Вид: {Species}, Харчування: {Diet}");
        }

        
    }

    public class Enclosure
    {
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Enclosure(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
        }

        public void AddAnimal(Animal animal)
        {
            if (Animals.Count < Capacity)
            {
                Animals.Add(animal);
            }
            else
            {
                Console.WriteLine("Вольєр переповнений!");
            }
        }

        public void DisplayEnclosureInfo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
                
            Console.WriteLine($"Вольєр типу {Type}, місткість: {Capacity}, кількість тварин: {Animals.Count}");
            
        }

        
        
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }


        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Працівник: {Name}, Посада: {Position}");
        }

    }

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

            Console.WriteLine("Вольєри");
            foreach(var enclosure in Enclosures)
            {
                enclosure.DisplayEnclosureInfo();
            }
        }
    }
}
