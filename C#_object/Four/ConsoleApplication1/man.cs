using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringTest
    {
        public StringTest(string s)
        {
            this.Str = s;
        }
        String _str;

        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }

        public void PrintStr()
        {
            Stopwatch sw = new Stopwatch(); //创建一个计时器
            sw.Start(); //开始计时

            for (int i = 0; i < 1000; i++)
            {
                Str += i;   // + 在这儿是拼接
            }

            Console.WriteLine("====================string + {0}==============", sw.Elapsed);  //显示时间

            Console.WriteLine(this.Str);
        }
    }

    class StringBuilderTest
    {
       static StringBuilder str = new StringBuilder();

        public static void PrintfStringBuilder()
        {
            Stopwatch sw = new Stopwatch(); //创建一个计时器
            sw.Start(); //开始计时

            for (int i = 0; i < 1000; i++)
            {
                str.Append(i);   //str += i; 这个的速度远远快于str += i;
            }
            Console.WriteLine("====================build {0}==============",sw.Elapsed);  //显示时间

            Console.WriteLine(str.ToString());  //转换为字符串输出
        }
    }

    class StringSegmentation
    {
        public static void  PrintfStringSeg()
        {
            string _str = "he+l__l>o w+o_r l d";
            char[] _seg = { ' ', '+', '_', '>' };   //需要分割出去的字符
            string[] str = _str.Split(_seg, StringSplitOptions.RemoveEmptyEntries); //分割不填充出去的字符位不填充空字符
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
