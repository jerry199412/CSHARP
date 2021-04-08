using System;
using System.Collections.Generic;
using System.Text;

namespace text
{
    class Cat : ISay
    {
        public void Say()
        {
            Console.WriteLine("猫会叫");
        }
    }
}
