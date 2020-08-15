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
            IFlyable Flay = new Mq();
            Flay.Flay();

            Flay = new Yw();
            Flay.Flay();

            Flay = new Zsfj();
            Flay.Flay();

            Flay = new Tl();
            Flay.Flay();

        }
    }
}
