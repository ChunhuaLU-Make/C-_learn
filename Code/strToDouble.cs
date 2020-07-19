using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 10 / 3.0;
            string str =  c.ToString("0.00");   //保留两位小数
            c = Convert.ToDouble(str);          //把string转为double
            Console.WriteLine(c);

        }
    }
}
