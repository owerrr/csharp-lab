using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Classes
{
    public class Adult : Human
    {
        public Adult() { }
        public Adult(string name) : base(name) { }
        public Adult(string name, Adult mother, Adult father) : base(name, mother, father) { }
        private List<Child> children = new List<Child>();

        public override string EatSnack() => "Cake.";

        public void AddChild(Child child)
        {
            children.Add(child);
        }

        public void AddChild(List<Child> childrens)
        {
            foreach (Child c in childrens)
            {
                children.Add(c);
            }
        }

        public int GetChildrenCount() => children.Count;
        public string GetChildrensNames()
        {
            string names = "";
            for(int i = 0; i < children.Count; i++)
            {
                if(i < children.Count -1)
                {
                    names += children[i].Name + ", ";
                }
                else
                {
                    names += "oraz " + children[i].Name;
                }
            }
            return names;
        }
    }
}
