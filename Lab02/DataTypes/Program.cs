Console.WriteLine("====== ZADANIE 1");

/* zadanie 1 */
Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 255;
int integralVariable = 341;
long longVariable = 1999999999000;
char charVariable1 = (char)96;
char charVariable2 = 'c';
double doubleVariable = 24.00099;
float floatVariable = 45e09F;
string stringVariable = "hello world!";
// tutaj wpisz rozwiązanie

Console.WriteLine(
    $"{byteVariable}\n{integralVariable}\n{longVariable}\n{charVariable1}" +
    $"\n{charVariable2}\n{doubleVariable}\n{floatVariable}\n{stringVariable}"
);


/* koniec zadania 1 */

Console.WriteLine("====== ZADANIE 2");

/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long longNum = num;
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int intBigNum = (int)bigNum;
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int stringToInt = int.Parse(stringNum);
// zbadaj zachowanie programu

Console.WriteLine(
    $"int to long = {longNum}\nlong to int = {intBigNum}\nstring to int = {stringToInt}"
);

/* koniec zadania 2 */

Console.WriteLine("====== ZADANIE 3");

/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
int e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;
// wypisz na ekran c,d,e,f,g
Console.WriteLine(
    $"{a}+{b} = {c}\n{a}-{b} = {d}\n{a}*{b} = {e}\n{a}/{b} = {f}\n{a}%{b} = {g}"
);
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine($"{price * price}");
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine($"{doubleVal*doubleVal}");
// zastanów się skąd się bierze różnica
//decimal bardziej precyzyjny niż double
// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine($"{Math.PI*Math.Pow(radius, 2)}");
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
int hours = (int)time/60;
int minutes = (int)(time/60)/60;
int seconds = (int)((time/60)/60)/60;

/* koniec zadania 3 */

Console.WriteLine("====== ZADANIE 4");

/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;

Console.WriteLine($"BEFORE CHANGE\n{toIncrement} | {toDivide}");
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;

Console.WriteLine($"AFTER CHANGE\n{toIncrement} | {toDivide}");

/* koniec zadania 4 */

Console.WriteLine("====== ZADANIE 5 ");

/* zadanie 5 */
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree);

Console.WriteLine($"sin{degree}° = {sinValue}");

/* koniec zadania 5 */

Console.WriteLine("====== ZADANIE 6 ");

/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime newDate = new DateTime(year, month, day, hour, minute, 0);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
newDate = newDate.AddMonths(3);
newDate = newDate.AddHours(-1);

Console.WriteLine(newDate.ToString());

// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia

Console.WriteLine(newDate.DayOfWeek.ToString());

/* koniec zadania 6 */

Console.WriteLine("====== ZADANIE 7 ");

/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
string text = firstPart + " " + secondPart + " " + thirdPart;
// pamiętaj o brakujących odstępach
// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine(text.ToUpper());
// oraz liczbę przedstawiającą długość tego ciągu znaków
Console.WriteLine(text.Length);

/* koniec zadania 7 */


Console.WriteLine("====== ZADANIE 8 ");

/* zadanie 8 */
double lengthA = 4;
double lengthB = 5;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool isTriangle = false;

if(lengthA + lengthB > lengthC
    && lengthA+lengthC > lengthB
    && lengthB+lengthC > lengthA)
{
    isTriangle = true;
}

// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
bool isRight = false;
if (Math.Pow(lengthA,2) + Math.Pow(lengthB,2) == Math.Pow(lengthC,2)
    || Math.Pow(lengthA, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthB, 2)
    || Math.Pow(lengthB, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthA,2))
{
    isRight = true;
}

Console.WriteLine(isTriangle ? isRight? "Jest to trojkat prostokatny" : "Jest to trojkat" : "Nie jest to trojkat.");

/* koniec zadania 8 */

Console.WriteLine("====== ZADANIE 9 ");

/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if(conditionalString.Length > 10)
    Console.WriteLine(conditionalString);

/* koniec zadania 9 */

Console.WriteLine("====== ZADANIE 10 ");

/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if(temperature > 20)
{
    Console.WriteLine("cieplo");
}
else
{
    Console.WriteLine("zimno");
}
Console.WriteLine("====== ZADANIE 11 ");
Console.WriteLine(temperature > 20 ? "cieplo" : "zimno");

/* koniec zadania 10 */



Console.WriteLine("====== ZADANIE 12 ");

/* zadanie 12 */
int code = 16;
int quantity = 47;
decimal productPrice = 3.5m;
decimal sellPrice = 0;

if(code < 10)
{
    sellPrice = quantity * productPrice;
}
else if(code < 16 && code >= 10)
{
    sellPrice = quantity * (productPrice * 0.95m);
}
else if(code >= 16)
{
    if(quantity <= 10)
    {
        sellPrice = quantity * (productPrice * 1.05m);
    }
    else if(quantity > 10 && quantity <= 20)
    {
        sellPrice = quantity * productPrice;
    }
    else if(quantity > 20 && quantity <= 100)
    {
        decimal bon = (quantity / 10)/100m;
        //Console.WriteLine($"bon = {bon}");
        sellPrice = quantity * (productPrice * bon);
    }
    else if(quantity > 100)
    {
        sellPrice = quantity * (productPrice * 0.9m);
    }
}

Console.WriteLine($"Price: {sellPrice.ToString()}");
/* koniec zadania 12 */

Console.WriteLine("====== ZADANIE 13 ");

/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;
    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;
    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;
    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;
    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;
    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;
    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;
    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;
    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;
    case 'A':
        Console.WriteLine($"Decimal number: 10");
        break;
    case 'B':
        Console.WriteLine($"Decimal number: 11");
        break;
    case 'C':
        Console.WriteLine($"Decimal number: 12");
        break;
    case 'D':
        Console.WriteLine($"Decimal number: 13");
        break;
    case 'E':
        Console.WriteLine($"Decimal number: 14");
        break;
    case 'F':
        Console.WriteLine($"Decimal number: 15");
        break;

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */