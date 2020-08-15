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
            string name = "wK";   //在堆上开辟了一个空间，用name指向
            string she = name; //在堆上开辟了一个空间，用she指向，把name指向的地址空间的内容拷贝到了she指向的内存空间
            name = "yL";   //在堆上重新开辟的了一个地址空间存储yL，再把name重新指向有yL的堆区。
        }
    }
}
