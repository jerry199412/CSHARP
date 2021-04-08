using System;
using System.Collections.Generic;
using System.Text;

namespace class5
{
    class Person
    {
        public Person(string name, int age, string hobby)
        {
            this.Name = name;
            this.Age = age;
            this.Hobby = hobby;
        }

        private string _name;
        private int _age;
        private string _hobby;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Hobby { get => _hobby; set => _hobby = value; }
    }
}
