using System;
using name;
namespace class8
{
    class Program
    {
        /// <summary>
        /// 多态 
        /// 虚方法
        /// 1、new （1）创建对象
        ///         （2）隐藏从父类那里继承过来的同名成员。隐藏后则子类无法调用父类的同名方法
        ///         
        /// 2、virtual  父类方法前添加  override 子类方法前添加
        /// 
        /// 抽象类
        /// 
        /// 访问修饰符
        /// public 公开公共的
        /// private私有的只能在当前类的内部访问
        /// protected受保护的，只能在当前类的内部以及改类的子类中访问
        /// internal：之恶能在当前项目中访问，在同一个项目中，internal与public的权限是一样的
        /// 
        /// 接口 
        /// 当一个类继承了一个接口需要实现其所有成员
        /// 接口中可以有返回值
        /// 接口中成员不添加访问修饰符
        /// 接口中不允许写有方法体的函数
        /// 接口中不允许写字段（因为其不存数据）
        /// 接口中不允许写属性  但是可以写自动属性 程序给自动属性添加字段自动属性和属性并没有什么区别
        /// 其本质只能存方法
        /// 
        /// 
        /// 接口注意的问题
        /// 1、其不能被实例化
        /// 2、接口可以继承接口，可实现多继承
        /// 3、接口不能继承类
        /// 4、一个类可以同时机车给一个类并实现多个接口，如果一个子类同时继承了父类H，并实现了接口IH，那么语法上H必须写在IH之前
        /// 
        /// 什么时候用虚方法实现多态
        /// 如果父类中的方法你知道怎么写，并且还需要创建这个父类的对象，就用虚方法
        /// 什么时候用虚方法实现多态
        /// 如果几个类中，你能提取出来一个父类并且父类当中并且父类当中必须协商几个子类共有的方法然后你还不知道怎么写这个方法
        /// 什么时候用接口来实现的多态
        /// 如果这几个类当中根本就提取不出来父类但是这几个类都有一个共同的行为或者能力
        /// 
        /// 
        /// 显式实现接口：：解决方法的重名问题
        /// 例如
        /// void  IA.Say()
        /// 
        /// 若B继承了A这个接口
        /// IA a = new B();
        /// a.say();使用的是子类实现接口的方法
        /// 
        /// B b = new B();
        /// b.say();使用的是子类自己的方法
        /// </summary>
        /// <param name="args"></param>
        string _gender//自动属性
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Dog dog = new Dog();
            Taidi taidi = new Taidi();
            Wolf[] wolves = { dog, taidi };

            for(int  i = 0; i<wolves.Length;i++)
            {
                wolves[i].speak();
            }

            animal an = new cat();

            an.Eat();

            Shape shape = new Circle(6);

            double area = shape.Area();
            double zhou = shape.Length();

            Console.WriteLine("{0}    {1}", area, zhou);
            Number1 number1 = new Number1();
        }
    }
}
