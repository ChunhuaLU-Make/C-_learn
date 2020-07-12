using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//求质数 只能被1跟它本身整除的数

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2, j = 0;
            while (true)
            {
                if (num == 0 || num == 1)
                {
                    Console.WriteLine("input not num");
                }

                if (j == num)
                {
                    break;
                }

                if (j % i == 0)
                {
                    if (i == j)
                    {
                        Console.WriteLine(j);
                    }
                    j++;
                    i = 2;

                    continue;
                }
                i++;

            }
        }
    }
}
