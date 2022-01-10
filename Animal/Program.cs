using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals platypus = new Platypus("Bobita", Categories.mammals, 10);
            platypus.CanWalk();
            platypus.CanSwim();
            Console.WriteLine("\n");

            Animals wildDuck = new WildDuck("Ducky", Categories.birds, 16);
            wildDuck.CanSwim();
            wildDuck.CanWalk();
            wildDuck.CanFly();
            Console.WriteLine("\n");

            Animals bat = new Bat("Man", Categories.mammals, 10);
            bat.CanFly();
        }
    }
}
