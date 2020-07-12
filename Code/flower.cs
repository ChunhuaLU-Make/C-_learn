using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 水仙花数
 * 百位的立方 + 十位的立方 + 个位的立方 == 当前数子
 * 百位 / 100
 * 十位 %100/10
 * 个位 %10
 */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 999; i++)
            {
                if (i == (((i / 100) * (i / 100) * (i / 100)) + (((i % 100) / 10) * ((i % 100) / 10) * ((i % 100) / 10)) + (i % 10) * (i % 10) * (i % 10)))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
