using System;
using System.Collections.Generic;
using System.Text;

namespace Stradegy.Quack
{
    class CatQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow meow!");
        }
    }
}
