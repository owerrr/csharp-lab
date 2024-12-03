using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Mammal : Animal
    {
        public void ProduceMilk()
        {
            Console.WriteLine("producing milk");
        }
    }
}
