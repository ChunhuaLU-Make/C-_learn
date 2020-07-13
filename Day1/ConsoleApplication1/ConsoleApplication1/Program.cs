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
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine("total:{0}", InputNum(num));
        }

        /// <summary>
        /// 保证能接受一个数字
        /// </summary>
        /// <param name="str">最开始传入的数字</param>
        /// <returns>返回接收到的数字</returns>
        public static int InputNum(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
               total += array[i];
            }
            return total;
        }
    }
}
