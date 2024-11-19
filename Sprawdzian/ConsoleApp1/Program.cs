namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1
            for(int i = b; i >= a; i--)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            void PrintTriangle(int height)
            {
                string triangle = "";
                int symbols = 1;
                
                for(int i = 1; i <= height; i++)
                {
                    triangle += new string(' ', height - i) + new string('$', symbols) + "\n";
                    symbols += 2;
                }

                Console.WriteLine(triangle);
            }
            // zaimplementuj poniższą procedurę
            PrintTriangle(10);
            Console.WriteLine("Kończę zadanie 2");
        }

        enum WeekDays
        {
            Poniedzialek = 1,
            Wtorek = 2,
            Sroda = 3,
            Czwartek = 4,
            Piatek = 5,
            Sobota =  6,
            Niedziela = 7
        }

        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;

            // tutaj rozwiązanie zadania 3
            string isMorning = today.Hour >= 12 ? "Dobry wieczor" : "Dzien dobry";
            string finalText = $"{isMorning}, dzisiaj {(WeekDays)today.DayOfWeek}, czyli {(int)today.DayOfWeek} dzien tygodnia";
            Console.WriteLine(finalText);

            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            double FindMaxAbsoluteValue(double[] nums)
            {
                double MAX = nums[0];
                    for(int i = 1; i < nums.Length; i++)
                    {
                        if (Math.Abs(nums[i]) > MAX) MAX = nums[i];
                    }
                return MAX;
            }
            // zaimplementuj poniższą funkcję
            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
            int choice = -1;
            while(choice != 0)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            break;
                        case 1:
                            Zadanie_1();
                            break;
                        case 2:
                            Zadanie_2();
                            break;
                        case 3:
                            Zadanie_3();
                            break;
                        case 4:
                            Zadanie_4();
                            break;
                        default:
                            Console.WriteLine("Nie ma takiego zadania, wybierz ponownie.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Podales/as nieprawidlowe dane!\nMusisz podac NUMER zadania od 1 do 4!");
                }
            }


            Console.WriteLine("Kończę pętlę.");
        }

    }
}