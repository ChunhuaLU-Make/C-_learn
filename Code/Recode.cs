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
            string num = Console.ReadLine();
            InputNum(num);
        }

        /// <summary>
        /// 保证能接受一个数字
        /// </summary>
        /// <param name="str">最开始传入的数字</param>
        /// <returns>返回接收到的数字</returns>
        public static int InputNum(string str)
        {
            while (true)
            {

                try
                {
                    int Recode = Convert.ToInt32(str);
                    return Recode;
                }
                catch
                {
                    Console.WriteLine("Please reinput");
                    str = Console.ReadLine();
                }
            }

        }
    }
}
