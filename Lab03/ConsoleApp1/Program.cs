Console.WriteLine("Zadanie 1");
zad1();
Console.WriteLine("\nZadanie 2");
zad2();
Console.WriteLine("\nZadanie 3");
zad3();
Console.WriteLine("\nZadanie 4");
zad4();
Console.WriteLine("\nZadanie 5");
zad5();
Console.WriteLine("\nZadanie 6");
zad6();
Console.WriteLine("\nZadanie 7");
zad7();
Console.WriteLine("\nZadanie 8");
zad8();
Console.WriteLine("\nZadanie 10");
zad10();
Console.WriteLine("\nZadanie 11");
zad11();
Console.WriteLine("\nZadanie 12");
zad12();
Console.WriteLine("\nZadanie 13");
zad13();
Console.WriteLine("\nZadanie 14");
zad14();

// zadanie 1
void zad1()
{
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i <= 10);
}

// zadanie 2

void zad2()
{
    string userPassword = "";
    string userInput = "";
    Console.WriteLine("Podaj haslo:");
    do
    {
        userInput = Console.ReadLine();
    } while (userInput != "koniec");
}

void zad3()
{
    int i = 0;
    while (i <= 100)
    {
        if (i % 2 == 0) Console.WriteLine(i);
        i++;
    }
}

void zad4()
{
    for (int i = 1; i <= 15; i++)
    {
        Console.WriteLine(Math.Pow(i, 2));
    }
}

void zad5()
{
    List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

    foreach (int n in numbers)
    {
        if (n % 7 == 0) Console.WriteLine(n);
    }
}

void zad6()
{
    List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

    foreach (int n in numbers)
    {
        if (n % 7 == 0)
        {
            Console.WriteLine(n);
            break;
        }
    }
}

void zad7()
{
    const int MAX_SIZE = 20;
    double[] numbers = new double[MAX_SIZE];

    for (int i = 0; i < MAX_SIZE; i++)
    {
        numbers[i] = Math.Sqrt(i + 1);
    }
}

void zad8()
{
    const int MAX_SIZE_COL = 3;
    const int MAX_SIZE_ROWS = 4;
    int[,] numbers_2D = new int[MAX_SIZE_COL, MAX_SIZE_ROWS];

    for (int i = 0; i < MAX_SIZE_COL; i++)
    {
        for (int j = 0; j < MAX_SIZE_ROWS; j++)
        {
            numbers_2D[i, j] = j;
        }
    }
}

void zad10()
{
    void toUppercase(string str)
    {
        Console.WriteLine(str.ToUpper());
    }

    toUppercase("wielkie litery");
}

void zad11()
{
    void createArray(int x, int y)
    {
        char[,] arr = new char[x, y];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                arr[i, j] = '$';
            }
        }

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (j == y - 1)
                {
                    Console.Write(arr[i, j] + "\n");
                }
                else
                {
                    Console.Write(arr[i, j]);
                }
            }

        }
    }

    createArray(3, 4);
}

void zad12()
{
    string intToString(int input)
    {
        return input.ToString();
    }

    Console.WriteLine(intToString(25));
}

void zad13()
{
    char[,] charArray;
    int x, y;
    void WczytajZKlawiatury()
    {
        Console.Write("\nKreator tablicy\nPodaj wymiar X tablicy:");
        x = int.Parse(Console.ReadLine());
        Console.Write("\nPodaj wymiar Y tablicy: ");
        y = int.Parse(Console.ReadLine());

        charArray = new char[x, y];
    }
    void WypelnijTablice(int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 || i == n - 1)
                {
                    charArray[i, j] = '#';
                }
                else
                {
                    if (j == 0 || j == m - 1)
                    {
                        charArray[i, j] = '#';
                    }
                    else
                    {
                        charArray[i, j] = ' ';
                    }
                }
            }
        }
    }
    void WyswietlTabliceNaEkran(char[,] arr)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (j == y - 1)
                {
                    Console.Write(arr[i, j] + "\n");
                }
                else
                {
                    Console.Write(arr[i, j]);
                }
            }

        }
    }
    WczytajZKlawiatury();
    WypelnijTablice(x, y);
    WyswietlTabliceNaEkran(charArray);
}

void zad14()
{
    double a, b, c;
    Console.Write("\nOBLICZ ROWNANIE KWADRATOWE\n" +
                    "===============================" +
                    "Podaj A:\n > ");
    a = double.Parse(Console.ReadLine());
    Console.Write("\nPodaj B:\n > ");
    b = double.Parse(Console.ReadLine());
    Console.Write("\nPodaj C:\n > ");
    c = double.Parse(Console.ReadLine());

    double delta = Math.Pow(b, 2) - 4 * a * c;
    if (delta == 0)
    {
        double result = Math.Round((b * -1) / 2 * a,2);
        Console.WriteLine($"Rownanie kwadratowe ma jeden wynik!\n > {result}");
    }
    else if (delta > 0)
    {
        double result1 = Math.Round((b * -1 - Math.Sqrt(delta)) / 2 * a,2);
        double result2 = Math.Round((b * -1 + Math.Sqrt(delta)) / 2 * a,2);
        Console.WriteLine($"Rownanie kwadratowe ma dwa wyniki!\n > {result1}\n > {result2}");
    }
    else
    {
        Console.WriteLine("Rownanie kwadratowe nie ma ani jednego wyniku!\n(delta wyszla ujemna)");
    }
}
