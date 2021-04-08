using System;
using System.Collections.Generic;
using System.Text;

namespace class3
{
    public class Man
    {
        private string _name;
        public int _age;
        public char _gender;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { if(value<0||value>100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        public char Gender
        {
            get { if(_gender == '男'||_gender == '女')
                {
                    return _gender;
                }
                return _gender = '男';
            }
            set
            {
                _gender = value;
            }
        }
        public void Hobby()
        {
            Console.WriteLine("没啥爱好");
        }
        public static void Ae()
        {

        }

        public void Ad()
        {

        }
    }
}
