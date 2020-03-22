using System;
using System.Collections.Generic;
using System.Text;

namespace Stradegy.Quack
{
    class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Sqwish!");
        }
    }
}
