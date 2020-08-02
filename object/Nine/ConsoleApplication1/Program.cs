using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //求圆面积，跟矩形周长和面积,使用抽象类的方法实现
            Calculate Cyl = new Circle(5.3);
            Console.WriteLine(Cyl.Area());
            Console.WriteLine(Cyl.Perimeter());

            Calculate Rec = new Rectangle(5, 3);
            Console.WriteLine(Rec.Area());
            Console.WriteLine(Rec.Perimeter());
        }
    }
}
