using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * ˮ�ɻ���
 * ��λ������ + ʮλ������ + ��λ������ == ��ǰ����
 * ��λ / 100
 * ʮλ %100/10
 * ��λ %10
 */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 999; i++)
            {
                if (i == (((i / 100) * (i / 100) * (i / 100)) + (((i % 100) / 10) * ((i % 100) / 10) * ((i % 100) / 10)) + (i % 10) * (i % 10) * (i % 10)))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
