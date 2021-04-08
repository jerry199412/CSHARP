using System;
using System.Collections.Generic;
using System.Text;

namespace class5
{
    class Bo:Person
    {
        public Bo(string name, int age, string hobby, string work)
          : base(name, age, hobby)
        {
            this.Work = work;
        }
        private string _work;

        public string Work { get => _work; set => _work = value; }

        public void FengSayHollo()
        {
            Console.WriteLine("我叫{0}，我的年龄是{1}，我的爱好是{2}，我的口头禅是{3}", this.Name, this.Age, this.Hobby, this.Work);
        }
    }
}
