using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class Cat : Mammal, IWalkable
    {
        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }

        public void Walk()
        {
            Console.WriteLine("I like walking on furniture and tables.");
        }

        public override string Sound => "Meow";

        public void ThrowOfTheTable()
        {
            Console.WriteLine("*cat throwed something from the table*");
        }
        //public override string ToString()
        //{
        //    return "I'm a Cat, I do " + this.Sound;
        //}
    }
}
