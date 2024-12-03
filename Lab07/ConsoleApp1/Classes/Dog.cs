using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class Dog : Mammal, IWalkable, ISwimmable
    {
        public override string Sound => "Woof";
        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
        public void Walk()
        {
            Console.WriteLine("I walk on a leash.");
        }
        public void Swim()
        {
            Console.WriteLine("I swim poorly...");
        }
        public void FetchBall()
        {
            Console.WriteLine("Just throw the ball and I'll fetch it!");
        }

        //public override string ToString()
        //{
        //    return "I'm a Dog, I do " + this.Sound;
        //}
    }
}
