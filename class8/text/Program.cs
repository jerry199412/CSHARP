using System;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            //猫会叫，狗会叫
            ISay say = new Cat();
            say.Say();

        }
    }
}
