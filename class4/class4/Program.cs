using System;

namespace class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个词语：");
            string numberOne = Console.ReadLine();
            numberOne = numberOne.ToUpper();
            Console.WriteLine("请再输入一个词语：");
            string numberTwo = Console.ReadLine();
            numberTwo = numberTwo.ToUpper();
            

            if (numberOne.Equals(numberTwo,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("我们都一样");
            }
            else
            {
                Console.WriteLine("我们不一样，有啥不一样");
            }
            ///转换大小写
            ///string.toUpper();
            ///string.toLower();
            ///判断是否相等
            ///string.Equals(str);有其他相比较的需求，可使用不同重载
            ///分割字符串
            ///string.Split(需要分割的字符);有其他需求可使用不同重载
            ///截取字符串
            ///string.SubString()
            ///查找某个字符串再字符串中第一次出现的位置
            ///string.IndexOf(查询字符串)
            ///查找某个字符串再字符串中最后一次出现的位置
            ///string.LastIndexOf(查询字符串)
            ///包含
            ///string.Contains(string2)
            ///替换
            ///str.Replace(str1,str2);
            ///以某个字符串开头
            ///str.StartsWith(str2)
            ///以某个字符结束
            ///str.EdnsWith(str2)
            ///去除字串里空格
            ///str.Trim();
            ///str.TrimStart();
            ///str.TrimEnd();
            ///查看字符串是否为空
            ///str.IsNullOrEmpty()
            ///null不占内存
            ///“”占内存空间
            ///string 与stringBuilder  string 赋值需要开辟新空间  StringBuilder 赋值不需要开新空间
            ///
        }
    }
}
