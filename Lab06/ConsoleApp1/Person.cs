using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // class declaration
    public class Person : Appearance
    {
        public readonly static Person NewlyBornChild = new Person("", "") { BirthDate = DateTime.Today };
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

        public Person(string firstName, string lastName, DateTime birthDate,
            string eyesColor, string hairColor, bool hasFreckles)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.EyesColor = eyesColor;
            this.HairColor = hairColor;
            this.HasFreckles = hasFreckles;

            SetAge();
        }

        // properties
        //public string FirstName {
        //    get { return this.FirstName == null ? "Person's first name is null!" : this.FirstName; }
        //    set { }
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; private set; }
        public string EmailAddress { get; private set; }
        public Person Partner { get; set; }
        public Animal Pet { get; set; }
        public int? Height { get; private set; }
        private int Age { get; set; }


        // method


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        private void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
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
            if (this.Age == -1)
                SetAge();

            return this.Age >= 18;
        }
        private void setPartner(Person p) { this.Partner = p; }
        public static void Relate(Person p1, Person p2)
        {
            p1.setPartner(p2);
            p2.setPartner(p1);
        }

        public void AdoptAPet(Animal pet)
        {
            this.Pet = pet;
        }

        public bool HasPet() { return this.Pet != null; }
    }
}

