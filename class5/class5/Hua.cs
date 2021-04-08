using System;
using System.Collections.Generic;
using System.Text;

namespace class5
{
    class Hua:Person
    {
        public Hua(string name, int age, string hobby, string work)
          : base(name, age, hobby)
        {
            this.Work = work;
        }
        private string _work;

        public string Work { get => _work; set => _work = value; }

        public void HuaSayHollo()
        {
            Console.WriteLine("我叫{0}，我的年龄是{1}，我的爱好是{2}，我的工作是{3}", this.Name, this.Age, this.Hobby, this.Work);
        }
    }
}
