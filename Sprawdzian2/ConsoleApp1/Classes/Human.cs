using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Human
    {
        public string Name { get; set; }
        public Adult Mother { get; set; }
        public Adult Father { get; set; }

        public virtual string EatSnack() => "Ice cream!";

        public Human() { }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, Adult mother, Adult father)
        {
            Name = name;
            Mother = mother;
            Father = father;
        }
    }
}
