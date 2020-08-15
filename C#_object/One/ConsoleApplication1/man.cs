using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class man
    {
        public string name;
        public int eag;
        public int sex;

        public void DrinkMilk()
        {
            Console.WriteLine("My name is {0}, eag {1}, sex {2}", this.name, this.eag, this.sex);//this 指向想当前对象本身.
        }
    }

    /// <summary>
    /// 属性的练习
    /// </summary>
    class SuperMan
    {
        
         string _name;  //字段
        public string Name  //属性
        {
            get { return _name; }
            set { _name = value; }

        }

         int _eag; 
        public int Age   //属性
        {
            get {
                if (_eag > 18)
                {
                    _eag = 18;  //不能获取18的值，如果有大于18按18返回
                }
                return _eag; }
            set { _eag = value; }

        }

        int _sex;
        public int Sex   //属性
        {
            get { return _sex; }
            set {
                if (value != 0 && value != 1)   //value 只能是0或1，其他值默认是0
                {
                    value = 0;
                }
                _sex = value; }

        }

        public void DrinkMilk()
        {
            Console.WriteLine("My name is {0}, eag {1}, sex {2}", this._name, this.Age, this.Sex);//通过this.Sex属性的get获得数据
        }
    }
}
