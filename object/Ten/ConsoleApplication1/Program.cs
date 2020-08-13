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
            Dog hehe = new Dog("wangwang", 1);
            hehe.Func();
            hehe.DogFunc();

            Cat LoatCat = new Cat("miaomaio", 0);
            LoatCat.Func();
            LoatCat.CatFunc();
        }
    }
}
