using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> arrayEnumerable = ["test", "test2", "test3"];
            

            Letter l1 = new Letter();
            l1.Content = "Secret content of the letter";
            Messenger<IMessage<string>>.Send(l1);

            zad3();
            zad4();
        }
        public static void zad3()
        {
            ICollection<string> arrayCollection = ["test", "test2", "test3"];

            writeCollection(arrayCollection);

            Console.WriteLine("Adding \"test4\" to collection");
            arrayCollection.Add("test4");
            writeCollection(arrayCollection);

            Console.WriteLine("Checking count of collection");
            Console.WriteLine("COUNT = " + arrayCollection.Count);

            Console.WriteLine("Checking if \"test\" is in collection");
            Console.WriteLine(arrayCollection.Contains("test"));

            Console.WriteLine("Checking if collection is readonly");
            Console.WriteLine(arrayCollection.IsReadOnly);

            Console.WriteLine("Copying collection to array");
            string[] string_arr = new string[4];
            arrayCollection.CopyTo(string_arr, 0);
            Console.WriteLine("\nString Array: ");
            foreach (string s in string_arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\nEND OF STRING ARRAY\n");

            Console.WriteLine("Removing \"test\" in collection");
            arrayCollection.Remove("test");
            Console.WriteLine("Checking if \"test\" is in collection");
            Console.WriteLine(arrayCollection.Contains("test"));
            writeCollection(arrayCollection);

            Console.WriteLine("clearing collection");
            arrayCollection.Clear();
            writeCollection(arrayCollection);

            static void writeCollection(ICollection<string> collection)
            {
                Console.WriteLine("\nArray Collection: ");
                foreach (string s in collection)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine("\nEND OF ARRAY COLLECTION\n");
            }
        }

        public static IDictionary<int, Book> books = new Dictionary<int, Book>();
        public static int identity = books.Count;
        public static void zad4()
        {
            Console.WriteLine("\nLIBRARY\n");
            
            books[0] = new Book("Autor testowy", "Testowy tytul", 2024);
            identity = books.Count;
            
            string cmd = "";
            List<Book> tbooks = new List<Book>();
            while(cmd.ToLower() != "q")
            {
                Console.Write("\n=======================\n" +
                                "\tLIBRARY\n" +
                                "=======================\n" +
                                "Commands: \n" +
                                "1. Dodaj ksiazke\n" +
                                "2. Wyswietl wszystkie ksiazki\n" +
                                "3. Wyszukaj ksiazki\n" +
                                "Q. Koniec\n > ");
                cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        Add(ref books);
                        break;
                    case "2":
                        ShowAllBooks(books);
                        break;
                    case "3":
                        SearchForBook(books);
                        break;
                    default:
                        Console.WriteLine("Nieznana komenda!");
                        break;
                }
            }

            static void Add(ref IDictionary<int, Book> books)
            {
                try
                {
                    Console.Write("\nPodaj dane do nowej ksiazki:\nAutor: ");
                    string author = Console.ReadLine();
                    Console.Write("Tytul: ");
                    string title = Console.ReadLine();
                    Console.Write("Rok wydania: ");
                    int year = int.Parse(Console.ReadLine());

                    Console.Write("\n1. Potwierdz dane\n2. Edytuj dane\n3. Powrot\n > ");
                    string ans = Console.ReadLine();

                    while (ans.ToLower() != "1" && ans.ToLower() != "3") 
                    {
                        Console.Write($"\nWybierz co chcesz poprawic:\n1. Autor: {author}\n2. Tytul: {title}\n3. Rok: {year}\n4. Potwierdz dane\n5. Powrot\n > ");
                        string toEdit = Console.ReadLine();
                        switch (toEdit)
                        {
                            case "1":
                                Console.Write("Autor: ");
                                author = Console.ReadLine();
                                break;
                            case "2":
                                Console.Write("Tytul: ");
                                title = Console.ReadLine();
                                break;
                            case "3":
                                Console.Write("Rok wydania: ");
                                year = int.Parse(Console.ReadLine());
                                break;
                            case "4":
                            case "5": ans = "1";
                                break;
                            default:
                                Console.WriteLine("Nieprawidlowe dane! Sprobuj ponownie.");
                                break;
                        }
                    }

                    Book book = new Book(title, author, year);
                    books[identity] = book;
                    identity += 1;
                    Console.WriteLine("Pomyslnie dodano nowa ksiazke!\n" + book);
                }
                catch (Exception e) { Console.WriteLine("Wystapil nieoczekiwany blad:\n" + e); }
            }
            static void ShowAllBooks(IDictionary<int, Book> books)
            {
                if (books.Count > 0)
                {
                    Console.Write("\nWyswietl wszystkie ksiazki sortujac poprzez:\n1. Id\n2. Autor\n3. Tytul\n4. Rok wydania\n5. Powrot\n > ");
                    string ans = Console.ReadLine();
                    var orderedBooks = books.OrderBy(x => x.Key);
                    switch (ans)
                    {
                        case "1":
                            orderedBooks.OrderBy(x => x.Key);
                            break;
                        case "2":
                            orderedBooks = books.OrderBy(x => x.Value.Author);
                            break;
                        case "3":
                            orderedBooks = books.OrderBy(x => x.Value.Title);
                            break;
                        case "4":
                            orderedBooks = books.OrderBy(x => x.Value.Year);
                            break;
                        default:return;
                    }
                    foreach (var b in orderedBooks)
                    {
                        Console.WriteLine(b.Key + ". " + b.Value);
                    }
                }
                else Console.WriteLine("Aktualnie nie ma ani jednej ksiazki.\nW kazdym momencie mozesz dodac nowa!");
            }
        }

        static void SearchForBook(IDictionary<int, Book> books)
        {
            if(books.Count > 0)
            {
                Console.Write("\nPrzeszukaj liste ksiazek wzgledem:\n1. Id\n2. Autor\n3. Tytul\n4. Rok wydania\n5. Powrot\n > ");
                string ans = Console.ReadLine();
                if (int.Parse(ans) > 0 && int.Parse(ans) < 5)
                {
                    Console.Write("\nPodaj fraze: ");
                    string phrase = Console.ReadLine();
                    IDictionary<int, Book> foundBooks = new Dictionary<int, Book>();
                    switch (ans)
                    {
                        case "1":
                            foreach (var book in books)
                            {
                                if (book.Key == int.Parse(phrase)) foundBooks[book.Key] = book.Value;
                            }
                            break;
                        case "2":
                            foreach (var book in books)
                            {
                                if (book.Value.Author.ToLower().Contains(phrase)) foundBooks[book.Key] = book.Value;
                            }
                            break;
                        case "3":
                            foreach (var book in books)
                            {
                                if (book.Value.Title.ToLower().Contains(phrase)) foundBooks[book.Key] = book.Value;
                            }
                            break;
                        case "4":
                            foreach (var book in books)
                            {
                                if (book.Value.Year == int.Parse(phrase)) foundBooks[book.Key] = book.Value;
                            }
                            break;
                        default: return;
                    }
                    foreach (var b in foundBooks)
                    {
                        Console.WriteLine(b.Key + ". " + b.Value);
                    }
                }
                else { return; }
            }
            else Console.WriteLine("Aktualnie nie ma ani jednej ksiazki.\nW kazdym momencie mozesz dodac nowa!");
        }
        
    }
}
