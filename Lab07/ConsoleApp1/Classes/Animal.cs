using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Animal
    {
        public string PublicMember { get; set; }
        protected string ProtectedMember { get; set; }
        private string PrivateMember { get; set; }

        public const string Kingdom = "Animalia";
        public abstract string Sound { get; }
        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }

        public override string ToString()
        {
            return "I'm a " + this.GetType().Name +", I do " + this.Sound;
        }
    }
}
