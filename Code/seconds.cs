using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//������ݣ��ж������� ����400 ��4����100��
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int week = 46 / 7;
            int weekDay = 46 % 7;
            Console.WriteLine("46day is {0} week {1} day.", week, weekDay); //47���Ǽ����㼸��

            int day = 107653 / 86400;
            int sec = 107653 % 86400;

            int hour = sec / 3600;
            sec %= 3600;

            int min = sec / 60;
            sec %= 60;

            Console.WriteLine("107653 is {0}:{1}:{2}:{3}", day, hour, min, sec);    //107653�Ǽ����㼸ʱ�㼸���㼸��
        }
    }
}