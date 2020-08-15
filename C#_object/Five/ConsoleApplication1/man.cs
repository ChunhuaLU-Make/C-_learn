using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 用户输入的字符串逆向输出 "abcd" ==> "dcba"
    /// </summary>
    class NegativeSequence
    {
        string _str;
        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }

        public void funciton()
        {
            Console.WriteLine("Please input str:");
             this._str = Console.ReadLine();
            char[] array = this._str.ToCharArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                char a = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = a;
            }
            this._str = new string(array);
            Console.WriteLine(this._str);
        }
        
    }

    /// <summary>
    /// hello c sharp ==> sharp c hello
    /// </summary>
    class WordInverted
    {
        public WordInverted()
        {
            this.Str = "hello c sharp";
        }
        string _str;
        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }

        public void Fun_WordInverted()
        {
            string[] NewStr = Str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < NewStr.Length/2; i++)
            {
                string temp = NewStr[i];
                NewStr[i] = NewStr[NewStr.Length - 1 - i];
                NewStr[NewStr.Length - 1 - i] = temp;
                
            }
            this.Str = null;
            for (int i = 0; i < NewStr.Length; i++)
            {
                this.Str += NewStr[i] + " ";
            }
            Console.WriteLine(this.Str);
        }
    }

    /// <summary>
    /// 提取email中的用户名域名 1692470640@qq.com
    /// </summary>
    class qqcom
    {
        public qqcom()
        {
            this._email = "1692470640@qq.com";
        }

        string _email;

        public void EmailFenXi()
        {
            int pase;
            pase = this._email.IndexOf("@");
            Console.WriteLine(this._email.Substring(0, pase));
            Console.WriteLine(this._email.Substring(pase + 1));
        }
    }

    /// <summary>
    /// 从文件中读取书名跟作者名，书名跟作者名指定有不定长的空格，要截取空格，最后大于3格子的书名用
    /// ...填充，加作者名输出
    /// </summary>
    class ReadData
    {
        public ReadData()
        {
            this._path = @".\temp.txt";
            this._contents = File.ReadAllLines(_path, Encoding.UTF8);
        }

        string _path;
        string[] _contents;

        public void Output()
        {
            string str = null, str1 = null;
            for (int i = 0; i < this._contents.Length; i++)
            {
                if (this._contents[i].Length > 3)
                {
                    str = this._contents[i].Substring(0, 3);
                    str1 = this._contents[i].Substring(this._contents[i].LastIndexOf(" "));
                    str += "..." + str1;
                    Console.WriteLine(str);
                    str = null;
                }
                else
                {
                    str1 = this._contents[i].Substring(this._contents[i].LastIndexOf(" "));
                    str += "..." + str1;
                    Console.WriteLine(str);
                }
            }
        }
    }

    /// <summary>
    /// 用户自己输入查找输入字符串中e的所有位置
    /// </summary>
    class Input
    {
        string _inputdata;
        public string Inpudata
        {
            get { return _inputdata; }
            set { _inputdata = value; }
        }

        public void Fun()
        {
            this.Inpudata = Console.ReadLine();

            int Index = this.Inpudata.IndexOf('e');
            for (int i = 0; i < this._inputdata.Length; i++)
            {
                Console.WriteLine(Index);
                Index = this.Inpudata.IndexOf('e', Index+1);
                if (Index == -1)
                {
                    break;
                }
            }
        }
    }

    /// <summary>
    /// 替换yellow关键字为***
    /// </summary>
    class Switch
    {
        public Switch()
        {
            this._str = "this is yellow";
        }

        string _str;

        public void Fun()
        {
            if (_str.Contains("yellow"))  
            {
                _str = _str.Replace("yellow", "****"); 
            }
            Console.WriteLine(_str);
        }
    }

    /// <summary>
    /// 先把字符数组用 | 连接，然后再把 | 切割掉
    /// </summary>
    class Name
    {
        public Name()
        {
            
        }
        string[] _name = { "yinli", "lili", "yinyin", "yinyinlili" };

        public void Fun()
        {
            string str;
            str = string.Join("|", _name);
            Console.WriteLine(str);
            _name = null;
            _name = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < _name.Length; i++)
            {
                Console.WriteLine(_name[i]);
            }
            
        }
        
    }
}
