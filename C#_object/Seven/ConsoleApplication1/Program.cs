using System;
using System.Collections;
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
            ArrayList List = new ArrayList();
            List.Add(1);    //集合中放入int类型
            List.Add(3.14); //集合中放入double 类型
            List.Add("this is C#"); //集合中放入字符串
            List.AddRange(new int[] { 1, 2, 3, 4, 5 }); //集合中放入数组
            List.Add(List); //输出自己的命名空间
            List.Remove(3.14);  //移除3.14这个元素
            List.RemoveAt(0);   //移除下标为0的元素
            List.RemoveRange(0, 3); //移除下标为 0 - 3 的所有元素
            //List.Sort();    //排序，元素类型差不多才行，否则抛异常
            List.Reverse(); //反转List
            List.Insert(0, "hello world"); //在下标为0的元素前插入一个元素"hello world"
            List.InsertRange(1, new int[] { 1,2,3,4});  //在下标1的元素前插入数组
            bool Judege = List.Contains("3.14"); //判断是否包含3.14
            if (Judege == true)
            {
                List[1] = 9.99; //如果有3.14则替换为9.99
            }
            else List[1] = 3.14;
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]); //依次输出集合中的元素
            }
            List.Clear();
        }
    }
}
