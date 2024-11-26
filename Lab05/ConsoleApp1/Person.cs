using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // class declaration
    public class Person
    {
        // constructor
        public Person() { }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = -1;
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            SetAge();
        }

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; private set; }
        public string EmailAddress { get; private set; }
        private int Age { get; set; }

        // method
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        private void SetAge()
        {
            this.Age = (int)(DateTime.Now - this.BirthDate).TotalDays / 365;
        }

        public int GetAge()
        {
            if (this.Age == -1)
                SetAge();

            return this.Age;
        }

        public bool IsAdult()
        {
            if(this.Age == -1)
                SetAge();

            return this.Age >= 18;
        }
    }
}


