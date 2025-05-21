using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virysu
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string type, double weight, int age)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
        }

        public object Clone()
        {
            var clone = new Virus(Name, Type, Weight, Age);
            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }
            return clone;
        }

        public void Print(int level = 0)
        {
            Console.WriteLine($"{new string(' ', level * 2)}Virus: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                child.Print(level + 1);
            }
        }
    }
}
