using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public Animal(string name, string species)
        {
            this.Name = name;
            this.Species = species;
        }

        
    }
}
