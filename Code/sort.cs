using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * ð������
 */
namespace ConsoleApplication1
{
    public enum sex
    {
        man,
        woman
    }
    public struct stdent
    {
        public string _name; //����public����㲻������Ȩ�޲���
        public sex _sh;
        public int _eag;
    };
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        num[j] = num[j] + num[j + 1];
                        num[j + 1] = num[j] - num[j + 1];
                        num[j] = num[j] - num[j + 1];
                    }
                }

            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
        }
    }
}
