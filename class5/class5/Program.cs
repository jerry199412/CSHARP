﻿using System;

namespace class5
{
    /// <summary>
    /// 继承
    /// 
    /// 将一堆类中的一些共有成员单独抽取出来，作为一个父类，然后一堆类继承这个父类，共享父类的资源
    /// 
    /// 继承的两个特性
    /// 1.单根性，一个子类只能有一个父类
    /// 2.继承传递性
    /// 
    /// 可继承父类的属性和方法，但不能继承私有字段
    /// 子类并没有继承父类的构造函数，但是，
    /// 
    /// 
    /// 
    /// 里氏转换
    /// 子类对象可以直接赋值给父类                                            （父类的对象可以被赋值为子类的对象）（父类对象=new 子类）
    /// 子类对象可以调用父类中的的成员，但父类对象永远只能调用自己的成员      （再子类中可以定义父类的对象）
    /// 如果父类对象中装的是子类的对象，可以将这个父类对象强制转换为子类对象  （父类对象=new 子类   后父类对象可强转为子类对象）
    /// 
    /// is   as  两个关键字都可以进行类型转换。
    /// 
    /// is如果转换成功，返回true，失败返回false
    /// as 如果转换成功返回对象，失败返回null
    /// 例如 Ming d = f  as  Ming;
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}