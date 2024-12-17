using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Messenger<T> where T : IMessage<string>
    {
        public static void Send(T _class)
        {
            string msg = "Sending ";
            if (_class.GetType() == typeof(Letter)) msg += "Letter: ";
            else if (_class.GetType() == typeof(Email)) msg += "Email: ";
            else if (_class.GetType() == typeof(SMS)) msg += "SMS: ";
            else msg += "Unknown type (check Messenger.cs)";
            Console.WriteLine(msg + _class.Content);
        }
    }
}
