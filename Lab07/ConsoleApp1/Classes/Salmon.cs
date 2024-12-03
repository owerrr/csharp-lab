using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class Salmon : Animal, ISwimmable
    {
        public override string Sound => "Glub";
        public void Swim()
        {
            Console.WriteLine("I can swim really fast!");
        }

        //public override string ToString()
        //{
        //    return "I'm a Salmon, I do " + this.Sound;
        //}
    }
}
