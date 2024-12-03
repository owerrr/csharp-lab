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

            Dog dog2 = new Dog();
            dog2.Walk();

            IWalkable walkableDog = new Dog();
            walkableDog.Walk();

            Cat c1 = new Cat();
            c1.Walk();

            dog2.Swim();
            Salmon s1 = new Salmon();
            s1.Swim();

            Animal[] animals = { c1, dog, s1 };
            foreach(Animal a in animals)
            {
                //Console.WriteLine(a.GetType().Name);
                Console.WriteLine(a);
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
