using System;
using System.Collections.Generic;
using System.Text;

namespace text
{
    class Dog : ISay
    {
        public void Say()
        {
            Console.WriteLine("狗会叫");
        }
    }
}
