namespace ConsoleApp1
{
    internal class Program
    {
        public static double CountCoordsLength(Coords[] c)
        {
            double res = 0.0;
            for (int i = 0; i < c.Length-1; i++)
            {
                res += Math.Sqrt(Math.Pow(c[i].X - c[i + 1].X, 2) + Math.Pow(c[i].Y - c[i + 1].Y, 2));
            }
            return res;
        }

        public static int[] getMinAndMax(int[] input) {
            int[] res = { input[0], input[0] };
                for(int i = 1; i < input.Length; i++)
                {
                    if(res[0] > input[i]) res[0] = input[i];
                    else if(res[1] < input[i]) res[1] = input[i];
            }
            return res;
        }

        static void Main(string[] args)
        {
            Coords point1 = new Coords(1.0, 1.0);
            Console.WriteLine(point1);

            Coords point2 = new Coords(1.0, 1.0); ;

            if (point1.Equals(point2))
                Console.WriteLine("Equal structs");
            else
                Console.WriteLine("Different structs");

            Console.WriteLine("\n=========================\n\tZADANIE 1\n=========================");
            point1 = new Coords(1.0, 1.0);
            point2 = new Coords(2.0, 2.0);
            Console.WriteLine($"Line start=({point1.X},{point1.Y})  Line end=({point2.X},{point2.Y})");
            Coords[] coords = {point1, point2 };
            Console.WriteLine(CountCoordsLength(coords));

            Console.WriteLine("\n=========================\n\tZADANIE 2\n=========================");
            int[] minAndMaxInput = { 2, 3, 16, 2, -25, 2, 0, 1, 4 };
            int[] filtered = getMinAndMax(minAndMaxInput);
            Console.WriteLine($"Min = {filtered[0]}\nMax = {filtered[1]}");

            Console.WriteLine("\n=========================\n\tZADANIE 3\n=========================");
            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            Console.WriteLine($"Person={person1.FirstName} {person1.LastName}");
            //Console.WriteLine(DateTime.Today.ToString());

            
            Person person2 = new Person("Andrzej", "Kmicic", new DateTime(2001, 06, 22));
            string isAdult = person2.IsAdult() ? $"jestes pelnoletni!\nmasz juz {person2.GetAge()} lat!" : $"nie jestes pelnoletni!\nmasz dopiero {person2.GetAge()} lat!";
            Console.WriteLine($"Hej {person2.FirstName} {person2.LastName}!\nWidze, ze {isAdult}");
        }
    }
}
