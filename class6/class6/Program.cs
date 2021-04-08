using System;
using System.Collections;

namespace class6
{
    class Program
    {
        /// <summary>
        /// arrayList
        /// 
        /// Add添加
        /// AddRange添加集合元素
        /// Clear清空所有元素
        /// Remove清除单个元素
        /// RemoveAt根据下标清除元素
        /// RemoveRange根据下标去除一定范围的元素
        /// Sort升序排列
        /// Reverse反转
        /// Insert在指定位置插入单个元素
        /// InsertRange在指定位置插入一个集合
        /// Contains判断是否包含
        /// 
        /// 
        /// 
        /// 集合长度
        /// count：集合中实际包含的个数
        /// Capcity：表示这个集合中可以包含的元素个数
        /// 
        /// 
        /// 泛型集合
        /// 其方法与arraylist一样
        /// 转换为数组
        /// ToArray()
        /// 转换为泛型集合
        /// toarraylist
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //创建一个集合，集合里面添加三个数字，求平均值与和
            ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3 });
            //int sum = 0;

            //for(int i = 0;i<list.Count;i++)
            //{
            //    sum += (int)list[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum / 3);

            //创建一个长度为10 的集合，要求在里面随机存放10个数字
            //但要求所有的数字不能重复

            Random random = new Random();
            
            while(true)
            {
                if(list.Count>=10)
                {
                    break;
                }
                int num = random.Next(0, 10);
                if (!list.Contains(num))
                {
                    list.Add(num);
                }
            }
            for(int i = 0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
