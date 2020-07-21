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
            ClassName xiaoHua = new ClassName("WangKing", 12);
            xiaoHua.Say();

            Student She = new Student();
            She.Name = "LongShan";
            She.Sex = 1;
            She.Eag = 95;
            She.Say();
            while (true) ;  //并未输出xigou，代表程序结束才调用析构，并不是对象使用完就释放类。
        }
    }
}
