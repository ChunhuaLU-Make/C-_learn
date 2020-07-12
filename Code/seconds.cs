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
            int week = 46 / 7;
            int weekDay = 46 % 7;
            Console.WriteLine("46day is {0} week {1} day.", week, weekDay); //47天是几周零几天

            int day = 107653 / 86400;
            int sec = 107653 % 86400;

            int hour = sec / 3600;
            sec %= 3600;

            int min = sec / 60;
            sec %= 60;

            Console.WriteLine("107653 is {0}:{1}:{2}:{3}", day, hour, min, sec);    //107653是几天零几时零几分零几秒
        }
    }
}