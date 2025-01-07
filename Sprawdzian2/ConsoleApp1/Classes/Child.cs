using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Child : Human, ISinger
    {
        public Child() { }
        public Child(string name) { }
        public Child(string name, Adult mother, Adult father) : base(name, mother, father) { }
        public string Sing() => "Baby shark doo doo doo doo";
    }
}
