
internal class Program
{
    enum DayOfTheWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("\nZadanie 1\n");
        zad1();
        Console.WriteLine("\nZadanie 2\n");
        zad2();
        Console.WriteLine("\nZadanie 3\n");
        zad3();
        Console.WriteLine("\nZadanie 4\n");
        zad4();
        Console.WriteLine("\nZadanie 5\n");
        zad5();
        Console.WriteLine("\nZadanie 6\n");
        zad6();
        Console.WriteLine("\nZadanie 7\n");
        zad7();

        void zad1()
        {
            double[] QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
            {
                double delta = b * b - 4 * a * c;
                double deltaSqrt = Math.Sqrt(delta);
                double[] res = [0];
                if (delta > 0)
                {
                    res = [0, 0];
                    res[0] = (b * -1 - deltaSqrt) / 2 * a;
                    res[1] = (b * -1 + deltaSqrt) / 2 * a;
                }
                else if (delta == 0)
                {
                    res[0] = b * -1 / 2 * a;
                }

                return res;
            }

            foreach(double d in QuadraticEquation(0, 1, 4, 1))
            {
                Console.WriteLine(d);
            }
        }
        void zad2()
        {
            void Swap(ref double a, ref double b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double x = 10;
            double y = 20;

            Swap(ref x, ref y);

            Console.WriteLine($"x = {x}, y = {y}");
        }

        
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Multiply(double a, double b, double c)
    {
        return a * b * c;
    }
    public static double Multiply(params double[] list)
    {
        double sum = list[0];
        for (int i = 1; i < list.Length; i++)
        {
            sum *= list[i];
        }
        return sum;
    }

    public static void zad3()
    {
        double[] lista = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(Multiply(lista));
    }

    public static void zad4()
    {
        bool isWeekDay = false;
        void getWeekDay(int d)
        {
            if (d > 0 && d <= 7)
            {
                if (d == 6 || d == 7) isWeekDay = true;
                Console.WriteLine(isWeekDay ? $"Numer {d} to {(DayOfTheWeek)d}, jest to weekend." : $"Numer {d} to {(DayOfTheWeek)d}, nie jest to weekend.");
            }
            else
            {
                Console.WriteLine("Nieprawidlowy parametr!");
            }
        }

        getWeekDay(6);
    }

    public static void zad5()
    {
        string getFullDate(DateTime date)
        {
            string day = date.Day > 9 ? Convert.ToString(date.Day) : "0" + date.Day;
            string month = date.Month > 9 ? Convert.ToString(date.Month) : "0" + date.Month;
            string hour = date.Hour > 9 ? Convert.ToString(date.Hour) : "0" + date.Hour;
            string minute = date.Minute > 9 ? Convert.ToString(date.Minute) : "0" + date.Minute;
            string second = date.Second > 9 ? Convert.ToString(date.Second) : "0" + date.Second;
            string res =    $"DZIEN: {day}\nMIESIAC: {month}\nROK: {date.Year}\n" +
                            $"GODZINA: {hour}:{minute}:{second}\n" +
                            $"DZIENTYGODNIA: {date.DayOfWeek}";

            return res;
        }

        Console.WriteLine(getFullDate(DateTime.Now));
    }
    public static void zad6()
    {
        double DivideNumbers(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException ex)
            {
                return 0.0;
            }
        }

        Console.WriteLine(DivideNumbers(5, 0));
    }
    public static void zad7()
    {
        void SetYourNewPassword(string pass)
        {
            bool isUpper = false;
            bool isLower = false;
            bool specialChar = false;
            bool isDigit = false;
            if (pass.Trim() == "") throw new ArgumentException("Podane haslo jest puste!");
            else if (pass.Length < 10) throw new FormatException("Podane haslo musi zawierac co najmniej 10 liter!");
                foreach(char c in pass)
                {
                    if (char.IsUpper(c)) isUpper = true;
                    if (char.IsLower(c)) isLower = true;
                    if (char.IsDigit(c)) isDigit = true;
                    if (!char.IsLetterOrDigit(c)) specialChar = true;
                }
            if (!isUpper) throw new FormatException("Podane haslo nie zawiera duzych liter!");
            else if (!isLower) throw new FormatException("Podane haslo nie zawiera malych liter!");
            else if (!isDigit) throw new FormatException("Podane haslo nie zawiera cyfr!");
            else if (!specialChar) throw new FormatException("Podane haslo nie zawiera znakow specjalnych!");
            else Console.WriteLine("Haslo poprawne");
        }

        SetYourNewPassword("#HASLOOOOOOOOsdsd1234OOOOO");
    }
}