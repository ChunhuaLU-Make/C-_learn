using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            InputNum(num);
        }

        /// <summary>
        /// ��֤�ܽ���һ������
        /// </summary>
        /// <param name="str">�ʼ���������</param>
        /// <returns>���ؽ��յ�������</returns>
        public static int InputNum(string str)
        {
            while (true)
            {

                try
                {
                    int Recode = Convert.ToInt32(str);
                    return Recode;
                }
                catch
                {
                    Console.WriteLine("Please reinput");
                    str = Console.ReadLine();
                }
            }

        }
    }
}
