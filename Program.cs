using Stradegy.Quack;
using Stradegy.Fly;
using System;
using System.Collections.Generic;

namespace Stradegy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();

            ducks.Add(new Duck("Duck", new DefaultQuack(), new DefaultFly()));
            ducks.Add(new Duck("CatDuck", new CatQuack(), new DefaultFly()));
            ducks.Add(new Duck("WoodenDuck", new NoQuack(), new NoFly()));
            ducks.Add(new Duck("ExoticDuck", new ExoticQuack(), new DefaultFly()));

            foreach(var duck in ducks)
            {
                duck.Display();
                duck.Quack();
                duck.Fly();
                duck.Swim();
                Console.WriteLine("----------------------------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
