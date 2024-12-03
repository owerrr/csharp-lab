namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Person child = Person.NewlyBornChild;
            //child.FirstName = "Brian";
            //child.LastName = "Doe";

            //Person p1 = null;
            //if (p1 == null)
            //    Console.WriteLine("Person is null!");
            //else
            //    Console.WriteLine(p1.FirstName);

            Person p1 = new Person() { FirstName = "Jan", LastName = "Andrzej" };

            Person p2 = new Person("Andrzej", "Raciborz", new DateTime(2004, 06, 14), "blue", "brown", false);
            Animal dog1 = new Animal("Ruby", "Owczarek niemiecki");
            p2.AdoptAPet(dog1);
            Person p3 = new Person("Karol", "Andrzej", new DateTime(2004, 05, 12));
            Person.Relate(p2, p3);
            
            string isAdult = p2.IsAdult() ? "oznacza to, ze jestes pelnoletni!" : "oznacza to, ze jestes niepelnoletni...";
            string hasFreckles = p2.HasFreckles ? "posiada" : "nie posiada";
            string hasPet = p2.HasPet() ? $"Twoj zwierzak:\nImie:\t{p2.Pet.Name}\nRasa:\t{p2.Pet.Species}" : "";
            string hasPartner = p2.Partner != null ? $"Twoim partnerem jest:\nImie:\t\t{p2.Partner.FirstName}\nNazwisko:\t{p2.Partner.LastName}\nUrodzony:\t{p2.Partner.BirthDate.ToString("MM/dd/yyyy")}\nWiek:{p2.Partner.GetAge()}" : ""; 
            Console.WriteLine($"Hej {p2.FirstName} {p2.LastName}!\n\nUrodziles sie {p2.BirthDate.ToString("MM/dd/yyyy")},\nwiec masz {p2.GetAge()} lat!\n{isAdult}\n\nKolor oczu:\t{p2.EyesColor}\nKolor wlosow:\t{p2.HairColor}\nPiegi:\t\t{hasFreckles}\n\n{hasPet}\n\n{hasPartner}");
        
        
        }
    }
}
