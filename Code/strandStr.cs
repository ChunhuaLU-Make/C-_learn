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
        /// �ַ���ƴ��
        /// </summary>
        /// <param name="Name">�������Ҫƴ�ӵ��ַ�������</param>
        /// <returns>����ƴ�Ӻõ��ַ���</returns>
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
