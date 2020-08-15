using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Md5Encryption("321");
            Console.WriteLine(a);
        }
        static string Md5Encryption(string str)
        {
            /* 创建对象 */
            MD5 md5 = MD5.Create();
            //开始加密
            /* 先将数组转换为字节数组 */
            byte[] buffer = Encoding.GetEncoding("GBK").GetBytes(str);
            byte[] EncryData = md5.ComputeHash(buffer);
            string data = null;
            for (int i = 0; i < EncryData.Length; i++)
            {
                data += EncryData[i].ToString("x2");
            }
            return data;
        }
    }
}
