﻿using System;
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
}
