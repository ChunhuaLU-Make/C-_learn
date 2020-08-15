using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //构造函数
    public class ClassName
    {
        /* 构造函数可以重载 */
        public ClassName(string name, int eag, int sex)
        {
            this.Name = name;
            this.Eag = eag;
            this.Sex = sex;
        }

        /* 调用两个参数的构造函数，可以通过this调用其它重载的构造函数*/
        public ClassName(string name, int eag):this(name, eag, 1)
        {
            this.Name = name;
            this.Eag = eag;
        }

        public ClassName(string name)
        {
            this.Name = name;
        }

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _eag;
        public int Eag
        {
            get { return _eag; }
            set { _eag = value; }
        }

        int _sex;
        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public void Say()
        {
            Console.WriteLine("My name is {0}, eag {1}, sex{2}", this.Name, this.Eag, this.Sex);
        }

    }

    //析构函数
    public class Student
    {
        ~Student()
        {
            Console.WriteLine("xigou");
        }
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _eag;
        public int Eag
        {
            get { return _eag; }
            set { _eag = value; }
        }

        int _sex;
        public int Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public void Say()
        {
            Console.WriteLine("My name is {0}, eag {1}, sex{2}", this.Name, this.Eag, this.Sex);
        }

    }
}
