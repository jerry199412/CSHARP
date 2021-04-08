using System;

namespace class2
{
    class Program
    {
        public enum Gender
        {
            男,女
        }
        static void Main(string[] args)
        {
            string a = "123";
            string b = "456";
            int number1 = Convert.ToInt32(a);
            int number2 = Convert.ToInt32(b);
            Console.WriteLine(number1 + number2);
            Console.ReadKey();

            Gender s = Gender.男;
        }
    }
}
