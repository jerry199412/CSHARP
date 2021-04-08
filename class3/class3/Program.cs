using System;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Man jerry = new Man();//new实例化
            jerry.Name = "贾瑞";
            jerry.Age = 180;
            jerry._gender = '男';
            jerry.Hobby();

            jerry.Ad();
            Man.Ae();
        }
    }
}
