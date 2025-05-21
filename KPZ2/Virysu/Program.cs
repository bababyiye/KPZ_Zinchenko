using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virysu
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootVirus = new Virus("RootVirus", "TypeA", 5.0, 10);

            var child1 = new Virus("Child1", "TypeB", 3.0, 5);
            var child2 = new Virus("Child2", "TypeB", 2.5, 4);

            var grandChild1 = new Virus("GrandChild1", "TypeC", 1.2, 2);
            var grandChild2 = new Virus("GrandChild2", "TypeC", 1.0, 1);

            child1.Children.Add(grandChild1);
            child2.Children.Add(grandChild2);

            rootVirus.Children.Add(child1);
            rootVirus.Children.Add(child2);

            Console.WriteLine("Original Virus family:");
            rootVirus.Print();

            var clonedVirus = (Virus)rootVirus.Clone();

            Console.WriteLine("\nCloned Virus family:");
            clonedVirus.Print();

            clonedVirus.Name = "ClonedRootVirus";
            clonedVirus.Children[0].Name = "ClonedChild1";

            Console.WriteLine("\nAfter modification:");

            Console.WriteLine("Original Virus family:");
            rootVirus.Print();

            Console.WriteLine("\nCloned Virus family:");
            clonedVirus.Print();

            Console.ReadKey();
        }
    }
}
