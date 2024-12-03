using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            Console.WriteLine(animal.Sound);
            animal.Move();

            Dog dog = new Dog();
            Console.WriteLine(dog.Sound);
            dog.Move();

            //animal.FetchBall();
            dog.FetchBall();

            Console.WriteLine("\n=========================\n\tZADANIE 1\n=========================\n");
            Cat c1 = new Cat();
            c1.Move();
            Console.WriteLine(c1.Sound);
            c1.ThrowOfTheTable();

            Console.WriteLine("\n=========================\n\tZADANIE 2\n=========================\n");
            Dog dog2 = new Dog();
            dog2.Walk();

            IWalkable walkableDog = new Dog();
            walkableDog.Walk();

            Console.WriteLine("\n=========================\n\tZADANIE 3\n=========================\n");
            c1.Walk();

            Console.WriteLine("\n=========================\n\tZADANIE 4\n=========================\n");
            dog2.Swim();
            Salmon s1 = new Salmon();
            s1.Swim();

            Console.WriteLine("\n=========================\n\tZADANIE 5\n\tZADANIE 6\n=========================");
            Animal[] animals = { c1, dog, s1 };
            foreach(Animal a in animals)
            {
                //Console.WriteLine(a.GetType().Name);
                Console.WriteLine("\n"+a);
                if (a is Mammal)
                    (a as Mammal).ProduceMilk();
                if (a is ISwimmable)
                    (a as ISwimmable).Swim();            
            }

            //Console.WriteLine(c1);
            //Console.WriteLine(dog);
            //Console.WriteLine(s1);
        }
    }
}
