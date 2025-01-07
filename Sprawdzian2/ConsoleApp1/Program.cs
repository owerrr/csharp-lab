using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Structures;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nZadanie 1:");
            zad1();
            Console.WriteLine("\nZadanie 2:");
            zad2();
            Console.WriteLine("\nZadanie 3:");
            zad3();
            Console.WriteLine("\nZadanie 4:");
            zad4();
            Console.WriteLine("\nZadanie 5:");
            zad5();
            Console.WriteLine("\nZadanie 6:");
            zad6();
        }

        static void zad1()
        {
            Point3d point1 = new Point3d(1.5, 5.75, -7.0);
            Console.WriteLine(point1.GetDistanceFromOrigin());
        }

        static void zad2()
        {
            Adult father = new Adult("John");
            Adult mother = new Adult("Jane");
            Child child1 = new Child("Kevin", mother, father);
            Child child2 = new Child("Mike", mother, father);
            Child child3 = new Child("Wendy", mother, father);
            Console.WriteLine(child2.Sing());
            List<Child> childrens = new List<Child>() { child1, child2, child3 };
            father.AddChild(childrens);
            mother.AddChild(childrens);

            Console.WriteLine($"Dorosli {father.Name} i {mother.Name} majacy {father.GetChildrenCount()} dzieci: {father.GetChildrensNames()}");
        }

        static void zad3()
        {
            Human humanAdult = new Adult();
            Console.WriteLine(humanAdult.EatSnack());

            Human childAdult = new Child();
            Console.WriteLine(childAdult.EatSnack());
        }

        static void zad4()
        {
            Human[] humans = { new Adult(), new Child(), new Child(), new Adult() };
            foreach(Human h in humans)
            {
                if(h is ISinger)
                {
                    Console.WriteLine((h as ISinger).Sing()); 
                }
            }
        }

        static void zad5()
        {
            Child c1 = new Child();
            Child c2 = new Child();
            Child c3 = new Child();

            Singers<Child> singers = new Singers<Child>() { c1, c2, c3 };
            foreach(Child c in singers)
            {
                Console.WriteLine(c.Sing());
            }
        }

        static void zad6()
        {
            Book b1 = new Book("Ulysses", "James Joyce", 1922);
            Book b2 = new Book("Lolita", "Vladimir Nabokov", 1955);
            Book b3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
            Book b4 = new Book("In Search of Lost Time", "Marcel Proust", 1913);

            List<Book> books = new List<Book>() { b1, b2, b3, b4 };

            Console.WriteLine("Autorzy wypisani w kolejnosci alfabetycznej:");
            List<Book> sortedByAuthors = books.OrderBy(x => x.Author).ToList();
            foreach(Book book in sortedByAuthors)
            {
                Console.WriteLine(book.Author);
            }
            books.Add(new Book("Jakas ksiazka", "Madry Autor", 2016));

            List<Book> filteredBooks = new List<Book>();
            foreach(Book b in books)
            {
                DateTime today = DateTime.Now;
                if(today.Year - b.YearPublished > 100)
                {
                    filteredBooks.Add(b);
                }
            }
            Console.WriteLine("\nKsiazki starsze niz 100 lat:");
            foreach(Book b in filteredBooks) { Console.WriteLine(b.Title); }

            filteredBooks = books.OrderBy(x => x.YearPublished).ToList();
            filteredBooks.RemoveAt(0);
            books = filteredBooks;

            Console.WriteLine("\nAktualny zbior ksiazek:");
            foreach(Book b in filteredBooks)
            {
                Console.WriteLine(b);
            }
        }
    }
}
