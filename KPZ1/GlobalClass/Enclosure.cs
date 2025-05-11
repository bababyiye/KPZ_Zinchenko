using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalClass
{
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
}
