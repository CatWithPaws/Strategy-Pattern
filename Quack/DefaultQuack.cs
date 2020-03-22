using System;
using System.Collections.Generic;
using System.Text;

namespace Stradegy.Quack
{
    public class DefaultQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
