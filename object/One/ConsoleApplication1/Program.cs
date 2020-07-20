using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            man Wangking = new man();   //实例化一个对象
            Wangking.name = "xiaoji";
            Wangking.eag = 25;
            Wangking.sex = 1;
            Wangking.DrinkMilk();

            SuperMan guix = new SuperMan();
            guix.Name = "huangdi";  //只能通过属性访问字段
            guix.Age = 20;
            guix.Sex = 5;
            guix.DrinkMilk();

        }
    }
}
