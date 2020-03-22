using Stradegy.Quack;
using Stradegy.Fly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stradegy
{
    class Duck
    {
        protected string name;
        protected IQuackable quackable;
        protected IFlyable flyable;
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Display()
        {
            Console.WriteLine("Hi, I'm" + name);
        }
        public void Quack()
        {
            quackable.Quack();
        }
        public void Fly()
        {
            flyable.Fly();
        }
        public Duck(string _name, IQuackable _quack, IFlyable _fly)
        {
            name = _name;
            quackable = _quack;
            flyable = _fly;
        }
    }
}
