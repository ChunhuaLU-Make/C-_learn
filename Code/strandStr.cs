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
            string[] name = { "wangKing", "zhanGong", "Fangrong" };
            Console.WriteLine(StrAndStr(name));

        }
        /// <summary>
        /// 字符串拼接
        /// </summary>
        /// <param name="Name">传入的需要拼接的字符串数组</param>
        /// <returns>返回拼接好的字符串</returns>
        public static string StrAndStr(string[] Name)
        {
            string str = null;
            for (int i = 0; i < Name.Length - 1; i++)
            {
                str += Name[i] + "|";
            }
            return str + Name[Name.Length - 1];
        }
    }
}
