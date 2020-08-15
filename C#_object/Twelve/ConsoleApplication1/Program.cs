using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Mq: IFlyable
    {
        public void Flay()
        {
            Console.WriteLine("麻雀会飞");
        }
    }

    class Yw : IFlyable
    {
        public void Flay()
        {
            Console.WriteLine("鹦鹉会飞");
        }
    }

    class Tl : IFlyable
    {
        public void Flay()
        {
            Console.WriteLine("鸵鸟不会飞");
        }
    }

    class Zsfj : IFlyable
    {
        public void Flay()
        {
            Console.WriteLine("直升飞机会飞");
        }
    }

    public interface IFlyable   //接口的名字以 I 开头以ble结尾，表示I.....ble 什么的能力
    {
        // string name; //不能有字段,就意味着不能有构造函数。构造函数时初始化字段的。
        void Flay();    //只能有声明不能有实现。
    }
}
