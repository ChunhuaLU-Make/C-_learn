using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//输入年份，判断是润年 整除400 能4不能100是
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input year");
            string stryear = Console.ReadLine();
            int year = Convert.ToInt32(stryear);

            bool b = (year%400 == 0) || (year % 4 == 0 && year % 100 != 0);
             Console.WriteLine(b);
        }
    }
}