using System;
using System.Collections.Generic;
using System.Text;

namespace Stradegy.Fly
{
    class DefaultFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
