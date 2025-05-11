using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalClass;


namespace Console
{

    public class Program
    {

        static void Main()
        {

           

            Animal lion = new Animal("Лев", "Panthera leo", "М'ясоїдний");
            Animal zebra = new Animal("Зебра", "Equus zebra", "Травоїдний");
            Animal bear = new Animal("Ведмідь", "White", "М'ясоїдний");

            Enclosure big = new Enclosure("Великий", 5);
            big.AddAnimal(lion);
            big.AddAnimal(zebra);

            Enclosure small = new Enclosure("Малий", 2);
            small.AddAnimal(bear);


            Employee worker1 = new Employee("Іван", "Доглядач");
            Employee worker2 = new Employee("Марія", "Ветеринар");

            ZooInventory inventory = new ZooInventory();
            inventory.Animals.Add(lion);
            inventory.Animals.Add(zebra);
            inventory.Employees.Add(worker1);
            inventory.Employees.Add(worker2);
            inventory.Enclosures.Add(big);
            inventory.Enclosures.Add(small);

            inventory.DisplayInventory();




        }
    }
}
