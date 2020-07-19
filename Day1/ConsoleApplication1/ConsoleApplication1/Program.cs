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
            double c = 10 / 3.0;
          string str =  c.ToString("0.00");   //保留两位小数
            c = Convert.ToDouble(str);          //把string转为double
            //zhiNumber();
            //Console.WriteLine(InputNumber());
            //while (true)
            //{
            //    try
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        Ifclass(num);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Please input num");
            //    }
            //}
            //int[] array = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //int[] ret = ConverNum(array);
            //for (int i = 0; i < ret.Length; i++)
            //{
            //    Console.Write("{0} ", array[i]);
            //}
            //Console.WriteLine();

            //Cycle(5);
            string[] name = { "wangKing", "zhanGong", "Fangrong" };
            Console.WriteLine(StrAndStr(name));

        }

        public static void ZhiNumber()
        {
            string inputStr = "";
            int num = 0;
            int i = 0;
            while (true)
            {
                inputStr = Console.ReadLine();
                num = Convert.ToInt32(inputStr);

                for (i = 2; i < num; i++)
                {
                    if ((num % i) == 0)
                    {
                        Console.WriteLine("not zhi number");
                        break;
                    }
                }
                if (i == num)
                {
                    Console.WriteLine("is zhi number");
                    break;
                }
            }
        }

        public static int InputNumber()
        {
            while (true)
            {
                string str = Console.ReadLine();

                try
                {
                    int num = Convert.ToInt32(str);
                    return num;
                }
                catch
                {
                    Console.WriteLine("please input num");
                }

            }
        }

        public static void Ifclass(int sort)
        {
            if (sort >= 90 && sort <= 100)
            {
                Console.WriteLine("good");
            }
            else if (sort >= 80 && sort <= 89)
            {
                Console.WriteLine("linag");
            }
        }

        public static int[] ConverNum(int[] arr)
        {
            int[] SwitchNum = new int[arr.Length];
            int j = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                j--;
                SwitchNum[j] = arr[i];
                // 还有一种方法，前半部分跟后半部分对调
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = SwitchNum[i];
            }
            return SwitchNum;
        }

        public static void Cycle(double r)
        {
            double Pi = 3.14159;
            double MianJi = Pi * r * r;
            Console.WriteLine("mianji:"+MianJi);
            double CycleLong = 2 * Pi * r;
            Console.WriteLine("CycleLong:"+CycleLong);
        }

        public static string StrAndStr(string[] Name)
        {
            string str = null;
            for (int i = 0; i < Name.Length-1; i++)
            {
                str += Name[i] + "|";
            }
            return str + Name[Name.Length - 1];
        }
    }
}
