using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ListFunc
    {
       public void ListExercise()
        {
            //将一个数组奇数放在一个集合中，偶数放在一个集合中，
            //在将两个集合拼接到一起，并且奇数显示在左边 偶数显示在右边

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            List<int> total = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    list1.Add(num[i]);
                }
                else
                {
                    list2.Add(num[i]);
                }
            }
            list2.AddRange(list1);

            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]);
            }
            Console.WriteLine();
        }

        public void UserInput()
        {
            //用户输入一个字符串，用foreach赋值给一个字符数组
            string Input = Console.ReadLine();
            char[] ch = new char[Input.Length];
            int i = 0;
            foreach (var item in Input)
            {
                ch[i++] = item;
            }

            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }
        }
    }
     
}
